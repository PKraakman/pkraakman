using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CforBeginners
{
    public class Person
    {
        public string firstname;
        public string lastname;

        public void Introduce()
        {
            Console.WriteLine("hello {0}", firstname);
        }
    }
}
