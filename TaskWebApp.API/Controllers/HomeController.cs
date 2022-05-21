using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

namespace TaskWebApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetContent()
        {
            //Http.Client(). GEtStringAsync("example.com") herhangi bir web siteden bize datayı getirmektedir.
            var myTask = new HttpClient().GetStringAsync("http://www.ggogle.com");
            var data = await myTask;
            return Ok(data);
        }
    }
}
