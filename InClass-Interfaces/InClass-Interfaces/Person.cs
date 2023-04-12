using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Interfaces
{
    public class Person : IComparable<Person>, IEquatable<Person> //Implement C#'s interfaces, IComparable (requires CompareTo method) and IEquatable (requires Equals method)
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Bob";
            Age = 18;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }   

        public override string ToString()
        {
            return $"\nName: {Name}\nAge: {Age}";
        }

        public int CompareTo(Person? other)
        {
            //Comparing two items to determine which one goes first
            //Alphabetically by name
            //If they have the same name, then by age
            int nameCompare = Name.CompareTo(other.Name);
            if(nameCompare == 0) //if they have the same name
            {
                return Age.CompareTo(other.Age);
            }
            else //names are different
            {
                return nameCompare;
            }
        }

        public bool Equals(Person? other)
        {
            if(Name == other.Name && Age == other.Age)
            {
                return true;
            }
            return false;
        }
    }
}
