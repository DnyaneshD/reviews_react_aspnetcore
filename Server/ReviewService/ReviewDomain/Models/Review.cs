using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReviewService.Models
{
    public class Review
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Topic { get; set; }
        public string AutherReview { get; set; }
        public int Votes { get; set; }
        public int NumberOfViews { get; set; }
        public DateTime LastUpdated { get; set; }

        // Relationship to be set
        //public User User { get; set; }
        //public IEnumerable<SocialReview> SocialReviews {get; set;}
    }
}
