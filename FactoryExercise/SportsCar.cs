using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    internal class SportsCar: IVehicle
    {
        public int wheels { get; set; }

        public void Drive()
        {
            Console.WriteLine("This also has 4 wheels and will get you from A to B but much quicker");
        }
    }
}
