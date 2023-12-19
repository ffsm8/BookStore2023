using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDB;
using BookStore.Models.Models.Users;

namespace BookStore.DL.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
            InMemoryDB.AuthorsData.Add(author);
        }

        public List<Author> GetAll()
        {
            return InMemoryDB.AuthorsData;
        }
        public Author GetByID(int id)
        {
            return InMemoryDB.AuthorsData.First(a=>a.Id == id);
        }

        public void Remove(int id)
        {
                var author = GetByID(id);
                InMemoryDB.AuthorsData.Remove(author);
        }
    }
}
