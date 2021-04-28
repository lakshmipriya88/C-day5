using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    public class Program
    {
        public static void Main()
        {
            DateTime dob = new DateTime(1999, 4, 21);
            DateTime dt = DateTime.Now;
            int Day = dt.Day - dob.Day;
            int Month = dt.Month - dob.Month;
            int Year = dt.Year - dob.Year;
            Console.WriteLine(String.Format("Age: " + Year + " Year(s) " + Month + " Month(s) " + Day + " Day(s) "));
        }
    }
}
