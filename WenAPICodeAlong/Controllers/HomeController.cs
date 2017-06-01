using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WenAPICodeAlong.Models;

namespace WenAPICodeAlong.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult Delete(int id)
        {
            Book book = new ValuesController().Books.SingleOrDefault(b => b.ISBN == id);

            return View(book);
        }
        public ActionResult Add()
        {
            return View(new Book() { Author = new Author()});
        }
    }
}
