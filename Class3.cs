using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{


    interface IVehiculo
    {
        void Drive();
        bool Refuel(int a);
    }
    class class1 : IVehiculo
    {
        public int gasoline;

        void IVehiculo.Drive()
        {


            if (gasoline > 0)
            {
                Console.WriteLine(" the car is Driving, if the gasoline is greater than 0");
            }
            else
            {
                Console.WriteLine("car is not drive");
            }
        }


        bool IVehiculo.Refuel(int a)
        {
            gasoline = Convert.ToInt32(Console.ReadLine());
            gasoline = gasoline + a;
            return true;
        }
    }
    class Car
    {
        public static void Main()
        {

            Console.WriteLine("enter gasoline amount");

            class1 o = new class1();
            IVehiculo Interface1 = o;
            Interface1.Refuel(0);
            Interface1.Drive();
            Console.ReadLine();

        }

    }
}
