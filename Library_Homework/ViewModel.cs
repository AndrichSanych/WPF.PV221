using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Homework
{
    [AddINotifyPropertyChangedInterface]
    internal class ViewModel
    {
        public Book book1 = new Book("Wow", "Some description", "Authooor1", new DateOnly(2001, 6, 5));
        public Book book2 = new Book("Wow", "Some description", "Authooor2", new DateOnly(2001, 6, 5));
        public Book book3 = new Book("Wow", "Some description", "Authooor3", new DateOnly(2001, 6, 5));
        private ObservableCollection<Book> library = new ObservableCollection<Book> { };
        public IEnumerable<Book> Library => library;

        private int CurrentBook = -1;
        public Book SelectedBook { get; set; } = new Book();
        public void Init()
        {
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
        }

        public void Next()
        {
            if (CurrentBook != library.Count - 1)
            {
                CurrentBook++;
                SelectedBook = library[CurrentBook];
            }
        }

        public void Prev()
        {
            if (CurrentBook != 0)
            {
                CurrentBook--;
                SelectedBook = library[CurrentBook];
            }
        }

        public void Add(Book book)
        {
            library.Add((Book)book);
        }
    }
}
