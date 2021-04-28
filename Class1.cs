using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class Program
    {
        Program()
        {
            Console.WriteLine("Constructor am called");
        }
        ~Program()
        {
            Console.WriteLine("Destructor am called");
            Console.ReadLine();
        }
        static void Main()
        {
            Console.WriteLine("I am in Main pro");
            Program p = new Program();
        }
    }
}
