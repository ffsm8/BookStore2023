namespace BookStore.Models.Models.Users
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public int AuthorId { get; set; }
    }
}
