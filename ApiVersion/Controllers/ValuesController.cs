using Asp.Versioning;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiVersion.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("GetAll")]
        [ApiVersion("1", Deprecated = true)]
        public IActionResult GetAll()
        {
            return Ok("V1 GetAll Result");
        }

        [HttpGet("GetAll")]
        [ApiVersion("2")]
        public IActionResult GetAllV2()
        {
            return Ok("V2 GetAll Result");
        }
    }
}
