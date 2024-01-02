using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Platform.Data;

namespace Platform.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET: api/data
        [HttpGet]


        // ... other methods and code

// GET: api/data/relations
        [HttpGet("relations")]
        public ActionResult<IEnumerable<SimpleRelation>> GetRelations()
        {
            return new List<SimpleRelation>
            {
                new SimpleRelation { Source = "Achievement", Target = "Power" },
                new SimpleRelation { Source = "Benevolence", Target = "Security" },
                // ... add all other relations here
                new SimpleRelation { Source = "Self-Transcendence", Target = "Tradition" }
            };
        }

    }
}
