using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace WenAPICodeAlong.DataAccess
{
    public class BookDbContext: DbContext
    {
        public DbSet<WenAPICodeAlong.Models.Book> Books {get;set; }

        public BookDbContext() : base("sqlServer") { }
    }
}