namespace Foodnetic.Models
{
    public class Comment
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string AuthorId { get; set; }
        public User Author { get; set; }
    }
}
