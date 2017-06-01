using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WenAPICodeAlong.Models;

namespace WenAPICodeAlong.DataAccess
{
    interface IBookSource
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById (int id);
        void SaveBook (Book value);
        void DeleteBook(int id);
    }

}
