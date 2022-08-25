using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    internal class Motorcycle : IVehicle
    {
        public int wheels { get; set; }
        public int speed { get; set; }


        public void Drive()
        {
            Console.WriteLine("This motorcycle is a fast one.");
        }
    }
}
