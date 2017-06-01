using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WenAPICodeAlong.DataAccess;
using WenAPICodeAlong.Models;

namespace WenAPICodeAlong.Repositories
{
    public class BookRepository
    {
        private BookDbContext context = new BookDbContext();
        private static BookRepository instance = null;
        public static BookRepository Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new BookRepository();
                }
                return instance;
            }
        }
        public IEnumerable<Book> GetAllBooks()
        {
            return context.Books;
        }
        public Book GetBookByISBN(int aISBN)
        {
            return context.Books.Find(aISBN);
        }
        public void DeleteBook(int aISBN)
        {
            context.Books.Remove(GetBookByISBN(aISBN));
        }
        public void UpdateBook(Book newBookValues)
        {
            if (newBookValues != null)
                GetBookByISBN(newBookValues.ISBN).Assign(newBookValues);
        }
    }
}