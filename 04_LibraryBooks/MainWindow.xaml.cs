using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _04_LibraryBooks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new ViewModel();
        }
    }

    public class ViewModel
    {
        private ObservableCollection<Book> books = new ObservableCollection<Book>();

        public IEnumerable<Book> Books => books;

        public ViewModel()
        {
            books.Add(new Book() { Author= "F. Scott Fitzgerald", Title= "The Great Gatsby", Description = "The Great Gatsby is a 1925 novel by American writer F. Scott Fitzgerald. Set in the Jazz Age on Long Island, near New York City, the novel depicts first-person narrator Nick Carraway's interactions with mysterious millionaire Jay Gatsby and Gatsby's obsession to reunite with his former lover, Daisy Buchanan."});
        }

    }

    
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; } 
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }

        public override string ToString()
        {
            return $"{Author} {Title} {Description} {ReleaseDate.Year}";
        }
    }
}
