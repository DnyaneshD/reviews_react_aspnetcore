using System;

namespace ReviewService.Models
{
    public class SocialReview
    {
        public int Id { get; set; }
        public string Review { get; set; }
        public DateTime MyProperty { get; set; }
        public User User { get; set; }
        public string ReviewId { get; set; }
    }
}