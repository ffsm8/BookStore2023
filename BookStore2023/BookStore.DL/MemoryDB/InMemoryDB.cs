using BookStore.Models.Models.Users;

namespace BookStore.DL.MemoryDB
{
    public static class InMemoryDB
    {
        public static List<Author> AuthorsData = new List<Author>()
        {
            new Author()
            {
                Id = 1,
                Name = "Name 1",
                Birthday=DateTime.Now
            },
            new Author()
            {
                Id = 2,
                Name = "Name 2",
                Birthday=DateTime.Now
            },
            new Author()
            {
                Id = 3,
                Name = "Name 3",
                Birthday=DateTime.Now
            },
        };
        public static List<Book> BookData = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Title 1",
                AuthorId = 1
            },
            new Book()
            {
                 Id = 1,
                Title = "Title 2",
                AuthorId = 2
            },
            new Book()
            {
                 Id = 1,
                Title = "Title 3",
                AuthorId = 3
            },
            };
    }
}
