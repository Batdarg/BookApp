using BookAppDatos.Context;
using BookAppDatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAppDatos.Operation
{
    public class BookDAO
    {
        //Creamos un objeto de contexto BD
        public BookstoreContext contexto = new BookstoreContext();

        //Metodo para seleccionar a todos los libros
        public List<AuthorBook> SeleccionarLibros()
        {
            var books = from b in contexto.Books
                        join a in contexto.Authors on b.AutorId
                        equals a.Id
                        select new AuthorBook
                        {
                            Id = b.Id,
                            Title = b.Title,
                            Chapters = b.Chapters,
                            Pages = b.Pages,
                            Price = b.Price,
                            Author = a.Names
                        };
            return books.ToList();
        }

        public List<AuthorBook> SeleccioanrLibro(string title)
        {
            var books = from b in contexto.Books
                        join a in contexto.Authors on b.AutorId
                        equals a.Id
                        where (b.Title == title)
                        select new AuthorBook
                        {
                            Id = b.Id,
                            Title = b.Title,
                            Chapters = b.Chapters,
                            Pages = b.Pages,
                            Price = b.Price,
                            Author = a.Names
                        };
            return books.ToList();
        }

        public bool InsertarLibro(string title, int chapters, int pages, int price, int autorId, Author author)
        {
            try
            {
                Book books = new Book();
                books.Title = title;
                books.Chapters = chapters;
                books.Pages = pages;
                books.Price = price;
                books.AutorId = autorId;
                if (author != null)
                {
                    books.Autor = author;
                }
                contexto.Books.Add(books);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
