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

namespace Animals
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public DataGrid dg;
        public AddWindow(DataGrid dgAnimals, Animal animal)
        {       //update or delete
            InitializeComponent();
            dg = dgAnimals;
            buttonIns.IsEnabled = false;
            buttonIns.Visibility = Visibility.Hidden;
            textBoxIdAW.Text = Convert.ToString(animal.id);
            textBoxNameAW.Text = animal.name;
            textBoxSpeciesAW.Text =animal.species;
            textBoxAgeAW.Text = Convert.ToString(animal.age);
            textBoxIdAW.IsEnabled = false;
        }

        public AddWindow(DataGrid dgAnimals)
        {
            InitializeComponent();
            dg = dgAnimals;
        }
        public AddWindow(DataGrid dgAnimals,int i)
        {
            //insert only
            InitializeComponent();
            dg = dgAnimals;
            buttonDel.Visibility = Visibility.Hidden;
            buttonUpd.Visibility = Visibility.Hidden;
        }
        private void Button_InsertAW(object sender, RoutedEventArgs e)
        {
            try
            {
                Baza.Insert(textBoxIdAW.Text, textBoxNameAW.Text, textBoxSpeciesAW.Text, textBoxAgeAW.Text, dg);
                clearTB();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void Button_DeleteAW(object sender, RoutedEventArgs e)
        {
          Baza.Delete(textBoxIdAW.Text, dg);
            Close();
        }
        private void Button_UpdateAW(object sender, RoutedEventArgs e)
        {
            try
            {
                Baza.Update(textBoxIdAW.Text, textBoxNameAW.Text, textBoxSpeciesAW.Text, textBoxAgeAW.Text, dg);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void Button_BackAW(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void clearTB()
        {
            textBoxIdAW.Text = "";
            textBoxNameAW.Text = "";
            textBoxSpeciesAW.Text = "";
            textBoxAgeAW.Text = "";
        }
    }
}
