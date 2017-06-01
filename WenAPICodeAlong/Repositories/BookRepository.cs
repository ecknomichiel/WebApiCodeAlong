using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WenAPICodeAlong.DataAccess;
using WenAPICodeAlong.Models;

namespace WenAPICodeAlong.Repositories
{
    public class BookRepository
    {
        private IBookSource context = new BookDbContext();
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
            return context.GetAllBooks();
                
        }
        public Book GetBookByISBN(int aISBN)
        {
            return GetAllBooks().SingleOrDefault(b => b.ISBN == aISBN);
        }
        public void DeleteBook(int aISBN)
        {
            context.DeleteBook(aISBN);
        }
        public void AddOrUpdateBook(Book newBookValues)
        {
            context.SaveBook(newBookValues);
        }
    }
}