using System.Net.Http.Headers;
using System.Text;
using VDS.RDF;
using VDS.RDF.Query;
using VDS.RDF.Update;

namespace Platform.Data
{
    public struct Triple
    {
        public string Subject { get; set; }
        public string Predicate { get; set; }
        public string Object { get; set; }
    }

    public class DataRepository
    {
        /// <summary>
        /// The Endpoint of the GraphDB to connect to
        /// </summary>
        private static readonly string EndpointUrl;

        /// <summary>
        /// The graph prefix to use for the VAST project
        /// </summary>
        private static readonly string DefaultGraphPrefix;

        /// <summary>
        /// The username to use for the GraphDB
        /// </summary>
        private static readonly string Username;

        /// <summary>
        /// The password to use for the GraphDB
        /// </summary>
        private static readonly string Password;

        /// <summary>
        /// A helper method to normalize the provided identifier to a valid URI within the context of the VAST model (and dependencies)
        /// </summary>
        /// <param name="uri">The identifier in either URI format or without the prefix</param>
        /// <returns>A normalized URI to use</returns>
        private static string CreateVastUri(string uri)
        {
            if (uri.Contains("http:") ||
                uri.Contains("https:") ||
                uri.StartsWith("vast:") ||
                uri.StartsWith("xsd:") ||
                uri.StartsWith("rdf:") ||
                uri.StartsWith("rdfs:") ||
                uri.StartsWith("foaf:") ||
                uri.StartsWith("schema:")
               )
            {
                return $"{uri}";
            }

            if (uri.StartsWith("\""))
            {
                return uri;
            }

            return "https://www.vast-project.eu/vast#" + uri;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="raw">The raw representation of the object</param>
        /// <returns>A cleaned up string without the type</returns>
        private static string Cleanup(string raw)
        {
            if (raw.Contains("^^"))
            {
                // Literal with type - return only the literal part
                var parts = raw.Split("^^");
                return parts[0];
            }
            else
            {
                return raw;
            }
        }

        /// <summary>
        /// A helper method to normalize the provided string by replacing all invalid characters with underscores
        /// </summary>
        /// <param name="name">The source for the name/identifier</param>
        /// <returns>A normalized name that can be used as part of an URI to identify the object in the graph-db</returns>
        public static string CreateNameFromString(string name)
        {
            return name.Replace(" ", "_").Replace(":", "_").Replace("-", "_").Replace("(", "_").Replace(")", "_").Replace("/", "_").Replace(".", "_").Replace(",", "_").Replace(";", "_").Replace("'", "_").Replace("\"", "_").Replace("?", "_").Replace("!", "_").Replace("§", "_").Replace("%", "_").Replace("&", "_").Replace("{", "_").Replace("}", "_").Replace("[", "_").Replace("]", "_").Replace("=", "_").Replace("+", "_").Replace("*", "_").Replace("~", "_").Replace("#", "_").Replace("|", "_").Replace("<", "_").Replace(">", "_").Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue").Replace("ß", "ss").Replace("Ä", "Ae").Replace("Ö", "Oe").Replace("Ü", "Ue");
        }

        /// <summary>
        /// Initializes the DataRepository with the provided configuration
        /// </summary>
        static DataRepository()
        {
            //Read the data from the app.settings.json file
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();

            EndpointUrl = configuration["GraphDB:EndpointUrl"];
            DefaultGraphPrefix = configuration["GraphDB:DefaultGraphPrefix"];
            Username = configuration["GraphDB:Username"];
            Password = configuration["GraphDB:Password"];
        }

        /// <summary>
        /// The http client to use for the requests
        /// </summary>
        private HttpClient client;

        /// <summary>
        /// The query endpoint to use for the requests
        /// </summary>
        private SparqlQueryClient queryEndpoint;

        /// <summary>
        /// The backing field for the list of graphs that will be queried, if no graph is provided
        /// </summary>
        private string[] graphs = { null, "https://www.vast-project.eu/vast/graphs#surveyData" };

        /// <summary>
        /// The list of graphs that will be queried, if no graph is provided
        /// </summary>
        public string[] Graphs => graphs;

        public DataRepository()
        {
            client = new HttpClient();

            //Configure the return type
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/sparql-results+json"));

            //Configure the authentication
            var byteArray = Encoding.ASCII.GetBytes($"{Username}:{Password}");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            //Prepare the query endpoint
            queryEndpoint = new SparqlQueryClient(client, new Uri(EndpointUrl));
        }

        /// <summary>
        /// A helper method to return all objects of the provided type from the given graph. If no graph is provided, all graphs are queried.
        /// </summary>
        /// <param name="typeUri">The type of the object to retrieve</param>
        /// <param name="graphUri">The graph to query. If null, all graphs are queried</param>
        /// <returns></returns>
        public async Task<Dictionary<string, List<Triple>>> GetAllObjectsByTypeAsync(string typeUri, string graphUri = null)
        {
            var objects = new List<Triple>();

            foreach (var graph in graphs)
            {
                string query;
                if (graph == null)
                {
                    query = @"SELECT ?s ?p ?o WHERE { ?s rdf:type <" + typeUri + "> . ?s ?p ?o }";
                }
                else
                {
                    query = @"SELECT ?s ?p ?o WHERE { GRAPH <" + graph + "> { ?s rdf:type <" + typeUri + "> . ?s ?p ?o } }";
                }

                var namedGraphs = queryEndpoint.NamedGraphs;
                var results = await queryEndpoint.QueryWithResultSetAsync(query);
                foreach (var result in results)
                {
                    var subject = Cleanup(result["s"].ToString());
                    var predicate = Cleanup(result["p"].ToString());
                    var objectValue = Cleanup(result["o"].ToString());

                    //Ignore duplicate predicate/object combinations for same subject
                    if (objects.Any(x => x.Subject == subject && x.Predicate == predicate && x.Object == objectValue))
                    {
                        continue;
                    }

                    objects.Add(new Triple
                    {
                        Subject = subject,
                        Predicate = predicate,
                        Object = objectValue
                    });
                }
            }

            return objects.GroupBy(x => x.Subject).ToDictionary(x => x.Key, x => x.ToList());
        }

        public async Task<Dictionary<string, List<Triple>>> GetAllActivites()
        {
            var result = await GetAllObjectsByTypeAsync("https://www.vast-project.eu/vast#vastActivity");
            var result2 = await GetAllObjectsByTypeAsync("https://www.vast-project.eu/vast#Activity");

            //Combine the dictionaries
            foreach (var item in result2)
            {
                if (result.ContainsKey(item.Key))
                {
                    result[item.Key].AddRange(item.Value);
                }
                else
                {
                    result.Add(item.Key, item.Value);
                }
            }

            return result;
        }

        public async Task<Dictionary<string, List<Triple>>> GetAllStatements()
        {
            return await GetAllObjectsByTypeAsync("https://www.vast-project.eu/vast#vastStatement");
        }
    }
}
