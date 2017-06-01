using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WenAPICodeAlong.Models;
using WenAPICodeAlong.Repositories;

namespace WenAPICodeAlong.Controllers
{
    public class ValuesController : ApiController
    {
        
        public IEnumerable<Book> Books 
        { 
            get 
            { 
                return BookRepository.Instance.GetAllBooks(); 
            } 
        }
        
        // GET api/values
        public IEnumerable<Book> Get()
        {

            return BookRepository.Instance.GetAllBooks(); ;
        }

        // GET api/values/5
        public Book Get(int id)
        {
            return BookRepository.Instance.GetBookByISBN(id);
        }

        // POST api/values
        public void Post([FromBody]Book value)
        {
            BookRepository.Instance.AddOrUpdateBook(value);
        }

        // PUT api/values/5

        public void Put([FromBody]Book value)
        {
            BookRepository.Instance.AddOrUpdateBook(value);
        }

        // DELETE api/values/5
        [HttpGet]
        public void Delete(int id)
        {
            BookRepository.Instance.DeleteBook(id);
        }

        [HttpPost]
        public void Delete(Book b)
        {
            if (b != null)
                BookRepository.Instance.DeleteBook(b.ISBN);
        }
    }
}
