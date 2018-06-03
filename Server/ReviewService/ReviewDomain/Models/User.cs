namespace ReviewService.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProfilePic { get; set; }
        public string LastTokenIssued { get; set; }
        public string ProfileId { get; set; }
    }
}