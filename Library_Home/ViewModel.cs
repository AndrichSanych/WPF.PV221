using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Home
{
    [AddINotifyPropertyChangedInterface]
    internal class ViewModel
    {
        public Book book1 = new Book("Tiger Trappers", "A romantic adventure that intertwines the autobiographical facts of the author Ivan Bahrianyi, Tiger Trappers was published in 1944 in the Ukrainian periodical called Late Hour. The author, as an eyewitness, depicts the violence in the hell of concentration camps and the humiliation of human dignity that took place. This unique work highlights revolutionary events throughout its pages. No one can remain indifferent to the story when the ideals of the state are considered more important than the life of a person.", "Ivan Bahrianyi", new DateOnly(1944, 6, 5));
        public Book book2 = new Book("Kaidash’s Family", "Kaidash’s Family by Ivan Nechuy-Levytsky is a realistic story, that shows how private-owned instincts lead people to moral impoverishment. Absurd actions of the main characters, captivating plot and familiar situations, make it one of the classics of Ukrainian literature. Written from the unique perspective of a peasant in Ukraine in late nineteenth century, the novel is one of the best pieces to read at least once.", "Ivan Nechuy-Levytsky", new DateOnly(1869, 5, 15));
        public Book book3 = new Book("Eneida", "This Ukrainian poem, written by Ivan Kotlyarevsky, is based on the plot of the classic poem of Roman poet, Virgil. Eneïda was the first monument of Ukrainian literature that was created in spoken form of the Ukrainian language. The poem brilliantly depicted Ukrainian life and culture in the eighteenth century.", "Ivan Kotliarevsky", new DateOnly(1842, 9, 2));
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
