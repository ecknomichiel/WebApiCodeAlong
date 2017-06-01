namespace WenAPICodeAlong.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WenAPICodeAlong.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WenAPICodeAlong.DataAccess.BookDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WenAPICodeAlong.DataAccess.BookDbContext context)
        {
            List<Author> authors = new List<Author>()
            {
                new Author() { Id = 1, Name = "Ian Mc Ewan" },
                new Author() { Id = 2, Name = "Garth Nix" }
            };
            context.Books.AddOrUpdate(b => b.ISBN, new Book() {ISBN=111, Author = authors[0], Description="a book", PublishedYear=1980, Title="The cement garden"});
            context.Books.AddOrUpdate(b => b.ISBN, new Book() {ISBN=112, Author = authors[0], Description="a book", PublishedYear=1994, Title="Amsterdam"});
            context.Books.AddOrUpdate(b => b.ISBN, new Book() {ISBN=113, Author = authors[1], Description="a book", PublishedYear=1990, Title="Sabriel"});
            context.Books.AddOrUpdate(b => b.ISBN, new Book() {ISBN=114, Author = authors[1], Description="a book", PublishedYear=2003, Title="Lirael"});
        }
    }
}
