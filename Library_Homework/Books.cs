using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Homework
{
    [AddINotifyPropertyChangedInterface]
    internal class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public DateOnly ReleaseDate { get; set; }

        public Book(string Title, string Description, string Autor, DateOnly ReleaseDate)
        {
            this.Title = Title;
            this.Description = Description;
            this.Author = Autor;
            this.ReleaseDate = ReleaseDate;
        }
        public Book() { }
        public override string ToString()
        {
            return $"{Title} by {Author}    {ReleaseDate.Year}";
        }

    }
}
