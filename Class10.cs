using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public class program
    {
        public static void Main()
        {
            int[] array = { 2, 55, 6, 9, 46, 34 };
            Array.Sort(array);
            Console.WriteLine("Second Highest Value in Array:" + array[array.Length - 2]);
        }
    }
}
