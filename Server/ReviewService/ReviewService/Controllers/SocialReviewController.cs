using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReviewService.Controllers
{
    [Route("api/[controller]")]
    public class SocialReviewController : Controller
    {
        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }
    }
}
