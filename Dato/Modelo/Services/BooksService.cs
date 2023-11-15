using Libreria_EESA.Dato.ViewModels;
using Libreria_EESA.Dato.Modelo;
using System;

namespace Libreria_EESA.Dato.Modelo.Services
{
    public class BooksService
    {
        private AppDBContext _context;
        public BooksService(AppDBContext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            //_context.Books.Add(book);
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                Date = DateTime.Now,
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
    }
}
