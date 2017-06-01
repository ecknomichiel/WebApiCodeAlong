using System;

namespace WenAPICodeAlong.Models
{
    public class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Description { get; set; }
        public int PublishedYear { get; set; }

    }

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}