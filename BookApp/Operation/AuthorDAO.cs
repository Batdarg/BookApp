using BookAppDatos.Context;
using BookAppDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAppDatos.Operation
{
    public class AuthorDAO
    {
        //Creamos el objeto con el contexto
        public BookstoreContext context = new BookstoreContext();

        //Seleccionar todos los autores
        public List<Author> SeleccionarAutores()
        {
            var authors = context.Authors.ToList<Author>();

            return authors;
        }

        //Seleccionar todos los autores y sus libros
        public List<BookAuthor> SeleccionarAutoresLibros()
        {
            var books = from a in context.Authors
                        join b in context.Books on a.Id
                        equals b.AutorId
                        select new BookAuthor
                        {
                            Id = a.Id,
                            Names = a.Names,
                            Title = b.Title

                        };
            return books.ToList();
        }

        //Metodo para crear nuevos autores.
        public bool InsertarAutor(string name)
        {
            try
            {
                Author author = new Author();
                author.Names = name;
                context.Authors.Add(author);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
