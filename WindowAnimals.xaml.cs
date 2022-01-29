using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Animals
{
    /// <summary>
    /// Interaction logic for WindowAnimals.xaml
    /// </summary>
    public partial class WindowAnimals : Window
    {
        public WindowAnimals()
        {
            InitializeComponent();
            Baza.Search(dgAnimals);
        }

        private void Button_Modify(object sender, RoutedEventArgs e)
        {
            AddWindow aw = new AddWindow(dgAnimals);
            aw.ShowDialog();

        }
        private void Button_Insert(object sender, RoutedEventArgs e)
        {
            AddWindow aw = new AddWindow(dgAnimals,1);
            aw.ShowDialog();
        }
        private void Button_Delete(object sender, RoutedEventArgs e)
        {
            if (dgAnimals.SelectedItem != null)
            {
                Animal animal = dgAnimals.SelectedItem as Animal;
                Baza.Delete(Convert.ToString(animal.id), dgAnimals);
            }
            else
            {
                MessageBox.Show("Wybierz rekord");
            }

        }
        private void Button_Update(object sender, RoutedEventArgs e)
        {
            if (dgAnimals.SelectedItem!=null)
            {
                Animal animal = dgAnimals.SelectedItem as Animal;
                AddWindow aw = new AddWindow(dgAnimals, animal);
                aw.ShowDialog();
            }
            else
            {
                MessageBox.Show("Wybierz rekord");
            }
        }
        private void Button_Back(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void dgAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
