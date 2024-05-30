using Microsoft.AspNetCore.Mvc;

namespace JenkinsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SynopController : ControllerBase
    {
        #region Ctor

        public IConfiguration Configuration { get; set; }
        public SynopController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        #endregion

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(($"Welcome to Synop. Api Version : {Configuration.GetSection("ApiVersion").Value}"));
        }
    }
}
