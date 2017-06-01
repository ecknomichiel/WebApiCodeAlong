using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WenAPICodeAlong.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ISBN { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public string Description { get; set; }
        public int PublishedYear { get; set; }


        internal void Assign(Book value)
        {
            ISBN = value.ISBN;
            Title = value.Title;
            if (Author == null)
                Author = value.Author;
            else
                Author.Assign(value.Author);
            Description = value.Description;
            PublishedYear = value.PublishedYear;
        }
    }

    public class Author
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public void Assign(Author value)
        {
            if (value != null)
            {
                Id = value.Id;
                Name = value.Name;
            }
        }
    }
}