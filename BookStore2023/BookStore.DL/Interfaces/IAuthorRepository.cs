using BookStore.Models.Models.Users;
using System.Dynamic;

namespace BookStore.DL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();
        Author GetByID(int id);
        void Add(Author author);
        void Remove(int id); 
    }
}
