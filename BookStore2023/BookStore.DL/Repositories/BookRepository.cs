using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDB;
using BookStore.Models.Models.Users;

namespace BookStore.DL.Repositories
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            InMemoryDB.BookData.Add(book);
        }
        public List<Book> GetAll()
        {
            return InMemoryDB.BookData;
        }
        public Book GetByID(int id)
        {
            return InMemoryDB.BookData.First(a => a.Id == id);
        }
        public void Remove(int id)
        {
            var book = GetByID(id);
            InMemoryDB.BookData.Remove(book);
        }
    }
}
