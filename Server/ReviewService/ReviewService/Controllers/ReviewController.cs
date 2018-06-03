using Microsoft.AspNetCore.Mvc;
using ReviewData;
using ReviewService.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ReviewService.Controllers
{
    [Route("api/[controller]")]
    public class ReviewController : Controller
    {

        // GET: api/review
        [HttpGet]
        public IEnumerable<Review> Get()
        {
            using (var db = new ReviewDbContext())
            {
               return db.Reviews;
            }
        }

        // GET: api/review/id
        [HttpGet("{id}")]
        public IEnumerable<string> Get(int reviewId)
        {
            return new string[] { "value1"};
        }

        // POST api/<controller>
        [HttpPost]
        public async System.Threading.Tasks.Task PostAsync([FromBody]Review review)
        {
            using (var db = new ReviewDbContext())
            {
                db.Reviews.Add(review);
               await db.SaveChangesAsync();
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
