using BookStore.Models.Models.Users;

namespace BookStore.DL.Interfaces
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetByID(int id);
        void Add(Book book);
        void Remove(int id);
    }
}
