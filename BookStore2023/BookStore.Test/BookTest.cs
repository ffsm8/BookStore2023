using BookStore.BL.Services;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using Moq;

namespace BookStore.Test
{
    public class BookTest
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Book 1",
                AuthorId = 1,
                ReleaseDate = new DateTime(2011, 01,11)
            },
            new Book()
            {
                Id = 4,
                Title = "Book 4",
                AuthorId = 1,
                ReleaseDate = new DateTime(2014, 04,14)
            },
            new Book()
            {
                Id = 2,
                Title = "Book 2",
                AuthorId = 2,
                ReleaseDate = new DateTime(2012, 02,12)
            },
            new Book()
            {
                Id = 3,
                Title = "Book 3",
                AuthorId = 3,
                ReleaseDate = new DateTime(2013, 03,13)
            }
        };

        [Fact]
        public void GetAllBooksByAuthorId_Count_Check()
        {
            var expectedCount = 2;
            var authorId = 1;
            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAllBooksByAuthorId(authorId))
                .Returns(Books.Where(b => b.AuthorId == authorId).ToList());

            var service = new BookService(mockedBookRepository.Object);

            var result = service.GetAllBooksByAuthorId(authorId);

            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count);

        }
        [Fact]
        public void GetAllBooksByAuthorId_WrongId()
        {
            var expectedCount = 0;
            var authorId = 11;
            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAllBooksByAuthorId(authorId))
                .Returns(Books.Where(b => b.AuthorId == authorId).ToList());

            var service = new BookService(mockedBookRepository.Object);

            var result = service.GetAllBooksByAuthorId(authorId);

            Assert.NotNull(result);
            Assert.Equal(expectedCount, result.Count);

        }
        [Fact]
        public void TestCalculation_Result_Check()
        {
            var expectedResult = 14;
            var testNumber = 10;
            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAll())
                .Returns(Books);

            var service = new BookService(mockedBookRepository.Object);

            var result = service.TestCalculation(testNumber);

            Assert.Equal(expectedResult, result);


        }
        [Fact]
        public void RemoveBook_Count_Check()
        {
            var expectedResult = 13;
            var testNumber = 10;
            var mockedBookRepository = new Mock<IBookRepository>();
            mockedBookRepository.Setup(x => x.GetAll())
                .Returns(Books);

            var service = new BookService(mockedBookRepository.Object);

            var result = service.remove(testNumber);

            Assert.Equal(expectedResult, result);


        }
    }
}