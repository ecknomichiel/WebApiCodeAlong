using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WenAPICodeAlong.Models;


namespace WenAPICodeAlong.DataAccess
{
    public class BookDbContext : DbContext, IBookSource
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public BookDbContext() : base("sqlServer") { }

        public void SaveBook(Book value)
        {
            if (value != null && value.Author != null)
            {
                Book dbBook = GetBookById(value.ISBN);

                if (dbBook == null)
                {
                    Author dbNewAuthor = Authors.Find(value.Author.Id);
                    if (dbNewAuthor != null) //Make sure to not add a new author if this is an existing author
                        value.Author = dbNewAuthor;
                    Books.Add(value);
                }
                else
                {
                    if (value.Author.Id == 0)
                    {
                        //New Author
                        Authors.Add(value.Author);
                    }
                    dbBook.Assign(value);
                }
                SaveChanges();
            }
            else
            {
                throw new Exception(String.Format("Tried to store a book with incomplete values. Book or Author is null"));
            }
        }



        public IEnumerable<Book> GetAllBooks()
        {
            return Books.Include(b => b.Author);
        }

        public Book GetBookById(int id)
        {
            return GetAllBooks().SingleOrDefault(b => b.ISBN == id);
        }

        public void DeleteBook(int id)
        {
            Books.Remove(Books.Find(id));
            SaveChanges();
        }
    }
}