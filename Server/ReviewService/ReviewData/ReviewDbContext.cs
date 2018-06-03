using Microsoft.EntityFrameworkCore;
using ReviewService.Models;

namespace ReviewData
{
    public class ReviewDbContext: DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SocialReview> SocialReviews { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0");
            //optionsBuilder.UseSqlServer(@"Data Source =LAPTOP-QU4GQAMT\SQLEXPRESS; Initial Catalog = ReviewsDB; Integrated Security = True;");
        }
    }
}
