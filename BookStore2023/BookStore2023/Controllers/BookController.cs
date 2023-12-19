using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.Models.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore2023.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController()
        {
            _bookService = _bookService;
        }
        [HttpGet("GetBooksById")]
        public Book GetBooksById(int id)
        {
            return _bookService.GetById(id);
        }
        [HttpGet("GetAllBooks")]
        public List<Book> GetAllBooks()
        {
            return _bookService.GetAll();
        }
        [HttpPost]
        public void Add([FromBody] Book book)
        {
            _bookService.Add(book);
        }
        [HttpDelete]
        public void Remove([FromBody] Book book)
        {
            _bookService.Remove(id: book.Id);
        }
    }
}
