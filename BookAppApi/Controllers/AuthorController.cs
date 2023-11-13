using BookAppDatos.Models;
using BookAppDatos.Operation;
using Microsoft.AspNetCore.Mvc;

namespace BookAppApi.Controllers
{
    [Route("api")]
    [ApiController]
    public class AuthorController
    {
        private AuthorDAO authorDAO = new AuthorDAO();

        [HttpGet("Authors")]
        public List<Author> Authors()
        {
            return authorDAO.SeleccionarAutores();
        }

        [HttpGet("AuthorsBooks")]
        public List<BookAuthor> AuthorBooks()
        {
            return authorDAO.SeleccionarAutoresLibros();
        }

        [HttpPost("Author")]
        public bool insertarAutores([FromBody] Author author)
        {
            return authorDAO.InsertarAutor(author.Names);
        }
    }
}
