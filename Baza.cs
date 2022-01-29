using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Animals
{
    public class Baza
    {
        static public void Insert(string id,string name, string species, string age,DataGrid dgAnimals)
        {
            string connectionString = @"Data Source=DESKTOP-9EHFHC1\ANIMALSQLSERVER;Initial Catalog=AnimalsDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into NewTable values (@Id,@Name,@Species,@Age)", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(id));
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Species", species);
            cmd.Parameters.AddWithValue("@Age", int.Parse(age));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Insert successful");
            Search(dgAnimals);
        }
        static public void Update(string id, string name, string species, string age, DataGrid dgAnimals)
        {
            string connectionString = @"Data Source=DESKTOP-9EHFHC1\ANIMALSQLSERVER;Initial Catalog=AnimalsDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Update NewTable set Name=@Name, Species=@Species, Age= @Age where ID= @ID", con);
            cmd.Parameters.AddWithValue("@Id", int.Parse(id));
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Species", species);
            cmd.Parameters.AddWithValue("@Age", int.Parse(age));
            cmd.ExecuteNonQuery();

            Search(dgAnimals);
            con.Close();
            MessageBox.Show("Update successful");
        }
        static public void Delete(string id, DataGrid dgAnimals)
        {
            string connectionString = @"Data Source=DESKTOP-9EHFHC1\ANIMALSQLSERVER;Initial Catalog=AnimalsDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete NewTable where ID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(id));
            cmd.ExecuteNonQuery();

            Search(dgAnimals);
            con.Close();
            MessageBox.Show("Dzik3");
        }

        static public void Search(DataGrid dgAnimals)
        {
            string connectionString = @"Data Source=DESKTOP-9EHFHC1\ANIMALSQLSERVER;Initial Catalog=AnimalsDatabase;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from NewTable", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);


              List<Animal> items = new List<Animal>();
              foreach (DataRow row in dt.Rows)
              {
                Animal animal = new Animal();
                {
                    animal.id = (int)row[0];
                    animal.name = row[1].ToString();
                    animal.species = row[2].ToString();
                    animal.age = (int)row[3];
                }
                items.Add(animal);           
              }

            //z data table dane, kolekcja animals, kolekcja animals do item source DONE
            dgAnimals.ItemsSource = items;

        }

    }
}
