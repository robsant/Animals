using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml;
using System.Xml.Serialization;
using System.Data;
using System.Data.SqlClient;

namespace Animals
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		public MainWindow()
		{
			InitializeComponent();
			/*	if (File.Exists("C://Users/Robert/source/repos"))
				{
					items = Serialization.DeserializeToObject<List<Animal>>("C://Users/Robert/source/repos/test.xml");
				}
				else
				{
					items.Add(new Animal() { name = "sdfsdfsdn", species = "asd", age = "12312312334" });
					items.Add(new Animal() { name = "Jsohn", species = "sasd", age = "1sd2312312334" });
					items.Add(new Animal() { name = "Jdohn", species = "asdsd", age = "123sdasdad12312334" });
					//items.Add(new Person() { firstName = "Dodaj", lastName = "", pesel = "" });			
					//MainWindow.instance = this;
				}
				Animals.ItemsSource = items;
			}

			private void Animals_MouseClick(object sender, MouseEventArgs e)
			{
				//int i = Osoby.SelectedIndices[0];
				//string s = Osoby.Items[i].Text;
				Animal item = (Animal)Animals.SelectedItem;
				Window2 okno = new Window2(item);
				okno.Show();
			}
			private void Button_Dodaj(object sender, RoutedEventArgs e)
			{
				Animal item = new Animal();
				items.Add(new Animal() { name = item.name, species = item.species, age = item.age });
				//Osoby.ItemsSource = items;
				Animals.Items.Refresh();
				Window2 okno = new Window2((Animal)Animals.Items[Animals.Items.Count - 1]);
				okno.Show();
				//items.Add(new Person() { firstName = item.firstName, lastName = item.lastName, pesel = item.pesel });
			}
			private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
			{
				Serialization.SerializeToXml<List<Animal>>(items, "C://Users/Robert/source/repos/test.xml");
			}
			*/

		}

		

		private void Button_OpenAnimals(object sender, RoutedEventArgs e)
        {
			WindowAnimals wa = new WindowAnimals();
			wa.ShowDialog();
		}
		private void Button_OpenRaport(object sender, RoutedEventArgs e)
        {
			RaportWindow rw = new RaportWindow();
			rw.ShowDialog();
		}
	}
}

