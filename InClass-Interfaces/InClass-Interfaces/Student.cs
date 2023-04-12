using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Interfaces
{
    public class Student : Person, IComparable<Student> //When inheriting and implementing interfaces, the superclass MUST be listed before any interface(s)
    {
        public string Major { get; set; }

        public Student() : base()
        {
            Major = "";
        }

        public Student(string name, int age, string major) : base(name, age)
        {
            Major = major;
        }

        public int CompareTo(Student? other)
        {
            //Compare alphabetically by name
            return Name.CompareTo(other.Name);
        }
    }
}
