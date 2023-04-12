using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Interfaces
{
    public class TextFileWriter : IWriter
    {
        public void Write(string s)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("../../../Files/example.txt");

                writer.Write(s);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        public void WriteLine(string s)
        {
            StreamWriter writer = null;

            try
            {
                writer = new StreamWriter("../../../Files/example.txt");

                writer.WriteLine(s);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }
    }
}
