using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Animals
{

    public class Animal
    {
        public int id
        { get; set; }

        public string name
        { get; set; }

        public string species
        { get; set; }

        public int age
        { get; set; }
        public Animal(int id,string name, string species, int age)
        {
            this.id = id;
            this.name = name;
            this.species = species;
            this.age = age;
        }
        public Animal(Animal p)
        {
            id = p.id;
            name = p.name;
            species = p.species;
            age = p.age;
        }
        public Animal()
        {
            id = 1;
            name = "1";
            species = "2";
            age = 4;
        }
    }
}
