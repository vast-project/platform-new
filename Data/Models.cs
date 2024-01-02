namespace Platform.Data
{
    public class Marker
    {
        public Marker()
        {
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }

    public class Map
    {
        public Map()
        {
        }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Zoom { get; set; }
        public List<Marker> Markers { get; set; }
    }
    public class Article
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string HeroImage { get; set; }
        public string SmallImage { get; set; }
        public string Author { get; set; }
        public string Date { get; set; }
        public List<Section> Sections { get; set; }
        public List<string> Tags { get; set; }
    }

    public class Section
    {
        public string Type { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public Map Map { get; set; }
    }

    public class SearchListing
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public string Url { get; set; }
    }

    public class SimpleRelation
    {
        public string Source { get; set; }
        public string Target { get; set; }
    }


}
