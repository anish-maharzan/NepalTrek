using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NepalTrek.API.Models.Domain;

namespace NepalTrek.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region> {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name="Annapurna Region",
                    Code="ABC",
                    RegionImageUrl="https://www.marveladventure.com/uploads/editors/Annapurna-Base-Camp-Trek-in-January-and-February-1.jpg"
                },
                 new Region
                {
                    Id = Guid.NewGuid(),
                    Name="Langtang Region",
                    Code="LAN",
                    RegionImageUrl="https://www.magicalsummits.com/wp-content/uploads/2023/02/Langtang-Valley-Trek-1.jpg"
                },
            };

            return Ok(regions);
        }
    }
}
