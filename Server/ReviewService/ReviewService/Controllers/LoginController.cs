using Microsoft.AspNetCore.Mvc;

namespace ReviewService.Controllers
{
    [Route("api/[controller]")]
    public class LoginController : Controller
    {
        // GET api/login
        [HttpGet]
        public string Get()
        {
            return "All Good";
        }

        // POST api/login
        [HttpPost]
        public bool Post(string userName, string password)
        {
            if (userName == "test" && password == "password")
            {
                return true;
            }
            return false;
        }
    }
}
