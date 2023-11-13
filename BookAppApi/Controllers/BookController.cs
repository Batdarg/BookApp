using BookAppDatos.Models;
using BookAppDatos.Operation;
using Microsoft.AspNetCore.Mvc;

namespace BookAppApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class BookController
    {
        private BookDAO bookDAO = new BookDAO();

        [HttpGet("Books")]
        public List<AuthorBook> SeleccionarLibros()
        {
            return bookDAO.SeleccionarLibros();
        }

        [HttpGet("Book")]
        public List<AuthorBook> SeleccionarLibro(string title)
        {
            return bookDAO.SeleccioanrLibro(title);
        }

        [HttpPost("Book")]
        public bool InsertarLibro([FromBody] Book book)
        {
            return bookDAO.InsertarLibro(book.Title, book.Chapters, book.Pages, book.Price, book.AutorId, book.Autor);
        }
    }
}
