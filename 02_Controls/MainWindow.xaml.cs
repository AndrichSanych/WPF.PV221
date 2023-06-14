using System;
using System.Collections.Generic;
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

namespace _02_Controls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int i = 1;
        const int max = 13; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            if (i == max)
            {
                i = 0;
            }
            else
            {
                CountVisitoursLabel.Content = i.ToString();
                i++;
            }
        }

        private void Oreder_Click(object sender, RoutedEventArgs e)
        {
            if (Calendar.SelectedDates.Count == 0 || NameTextBox.Text == string.Empty || SurnameTextBox.Text == string.Empty || PhoneTextBox.Text == string.Empty || CountVisitoursLabel.Content.ToString() == "0" || AcceptCheckBox.IsChecked == false)
            {
                return;
            }

            string category = string.Empty;
            if (economRadioButton.IsChecked == true)
                category = economRadioButton.Content.ToString();
            else if (standartRadioButton.IsChecked == true)
                category = standartRadioButton.Content.ToString();
            else if (luxRadioButton.IsChecked == true)
                category = luxRadioButton.Content.ToString();
            else
                return;


            MessageBox.Show($@"{NameTextBox.Text} {SurnameTextBox.Text}
{PhoneTextBox.Text}
Count guests : {CountVisitoursLabel.Content}
Category: {category}
From: {Calendar.SelectedDates.First()}
To: {Calendar.SelectedDates.Last()}");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            NameTextBox.Text = string.Empty;
            SurnameTextBox.Text = string.Empty;
            PhoneTextBox.Text = string.Empty;

            i = 0;
            CountVisitoursLabel.Content = "0";

            economRadioButton.IsChecked = false;
            standartRadioButton.IsChecked = false;
            luxRadioButton.IsChecked = false;

            AcceptCheckBox.IsChecked = false;

            Calendar.SelectedDate = DateTime.Now;

        }
    }
}
