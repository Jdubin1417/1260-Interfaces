using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Interfaces
{
    public class Driver
    {
        public static void Main()
        {
            List<int> intList = new List<int>();
            intList.Add(5);
            intList.Add(2);
            intList.Add(9);
            intList.Add(6);
            intList.Add(1);

            intList.Sort();

            foreach(int i in intList)
            {
                Console.WriteLine(i);
            }    

            List<Person> peopleList = new List<Person>();
            peopleList.Add(new Person("Bob", 23));
            peopleList.Add(new Person("John", 67));
            peopleList.Add(new Person("Adam", 13));
            peopleList.Add(new Person("Steve", 45));

            peopleList.Sort();

            foreach (Person p in peopleList)
            {
                Console.WriteLine(p);
            }

            //The following discusses lambdas: useful, but not related to interfaces

            //NameOfMethod(arg1, arg2);

            //NoName(Person lhs, Person rhs)
            //{
            //  return lhs.Age.CompareTo(rhs.Age);
            //}

            //peopleList.Sort((Person lhs, Person rhs) => (lhs.Age.CompareTo(rhs.Age)));

            //foreach (Person p in peopleList)
            //{
            //    Console.WriteLine(p);
            //}

            //var square = (int x) => (x * x);

            //Console.WriteLine(square(3));

            //peopleList.RemoveAll((Person p) => (p.Age < 30));

            //foreach (Person p in peopleList)
            //{
            //    Console.WriteLine(p);
            //}

            ConsoleWriter cw = new ConsoleWriter();
            cw.Write("Hello to the console!");

            TextFileWriter tfw = new TextFileWriter();
            tfw.Write("Hello to the file!");

            IWriter writer = new ConsoleWriter();
            //IWriter writer2 = new TextFileWriter();

            writer.Write("Hello");
        }
    }
}
