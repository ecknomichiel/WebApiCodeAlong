using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WenAPICodeAlong.Models;

namespace WenAPICodeAlong.Controllers
{
    public class ValuesController : ApiController
    {
        private Book[] books;
        public ValuesController()
        {
            Author a1 = new Author() { Id = 1, Name = "Ian Mc Ewan" };
            Author a2 = new Author() { Id = 2, Name = "Garth Nix" };
            books = new Book[] { 
                new Book() {ISBN=111, Author = a1, Description="a book", PublishedYear=1980, Title="The cement garden"},
                new Book() {ISBN=112, Author = a1, Description="a book", PublishedYear=1994, Title="Amsterdam"},
                new Book() {ISBN=113, Author = a2, Description="a book", PublishedYear=1990, Title="Sabriel"},
                new Book() {ISBN=114, Author = a2, Description="a book", PublishedYear=2003, Title="Lirael"}
                };
        }
        
        // GET api/values
        public IEnumerable<Book> Get()
        {

            return books;
        }

        // GET api/values/5
        public Book Get(int id)
        {
            return books.SingleOrDefault(b => b.ISBN == id);
        }

        // POST api/values
        public void Post([FromBody]Book value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]Book value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
