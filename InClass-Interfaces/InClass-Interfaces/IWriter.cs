using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Interfaces
{
    public interface IWriter //An interface: a contract stating you must implement the given methods
    {
        public void Write(string s);
        public void WriteLine(string s);
    }
}
