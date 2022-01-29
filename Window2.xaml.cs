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
    /// Interaction logic for Okno2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2(Animal animal)
        {
            InitializeComponent();
            ctlGrid.DataContext = animal;
        }
        // private void Button_Aktualizuj(object sender, RoutedEventArgs e)
        // {
        // List<Person> items = new List<Person>();
        // ctlGrid.DataContext = osoba;       
        // items.Add(new Person() { firstName = TBfirstName.Text, lastName = TBlastName.Text, pesel = TBpesel.Text });
        // Osoby.ItemsSource = items;
        // }

        public Animal returnValue
        {
            get { return ctlGrid.DataContext as Animal; }
        }
    }
}
