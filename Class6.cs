﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class program
    {
        public static void Main()
        {
            //DateTime dt= newDateTime(2021,5,28,3,25,5);
            //Console.WriteLine(String.Format("{0:ddd,MMM d, yyyy}", dt));


            //Console.WriteLine("Date and time: ");
            DateTime dt = DateTime.Now;
            Console.WriteLine(String.Format("{0: MMMM}", dt));
            Console.ReadLine();
        }
    }
}
