using BookStore.BL.Interfaces;
using BookStore.Models.Models;
using BookStore.DL.Interfaces;

namespace BookStore.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<Book> GetAllBooksByAuthorId(int authorId)
        {
            return _bookRepository.GetAllBooksByAuthorId(authorId);
        }
    }
}