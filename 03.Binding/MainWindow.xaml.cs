using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
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

namespace _03.Binding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ViewModel viewModel = new();

        ObservableCollection<Color> colors = new ObservableCollection<Color>();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = viewModel;
            ColorCollection.ItemsSource = colors;
        }

        private void AddNewColorBtnClick(object sender, RoutedEventArgs e)
        {
            colors.Add(viewModel.SelectedColor);
        }

        private void RemoveColorBtnClick(object sender, RoutedEventArgs e)
        {
            if (ColorCollection.SelectedItem != null) 
            {
                colors.Remove(viewModel.SelectedColor);
            }
        }
    }

    [PropertyChanged.AddINotifyPropertyChangedInterface]
    public class ViewModel
    {
        public byte Alpha { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }

        public Color SelectedColor => Color.FromArgb(Alpha, Red, Green, Blue);

    }


    
}
