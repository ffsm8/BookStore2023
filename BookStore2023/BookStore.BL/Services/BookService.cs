using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;

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

        public int TestCalculation(int number)
        {
            var books=_bookRepository.GetAll();
            return books.Count+number;
        }
        public int remove(int number)
        {
            var books = _bookRepository.GetAll();
            return books.Count - number;
        }

        public List<Book> GetAll()
        {
            throw new NotImplementedException();
        }

        public Book GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> GetAllByAuthorAfterReleaseDate(int authorId, DateTime afterDate)
        {
            throw new NotImplementedException();
        }
    }
}