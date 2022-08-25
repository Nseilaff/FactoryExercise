using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    internal class Car : IVehicle

    {
        public int wheels { get; set; }


        public void Drive()
        {
            Console.WriteLine("This is a practical car to get you from A to B");
        }
    }
}
