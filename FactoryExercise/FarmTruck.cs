using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    internal class FarmTruck: IVehicle
    {
        public int wheels { get; set; } 

        public void Drive()
        {
            Console.WriteLine("This is not so much an A to B vehicle. But will haul anything you need it to");
        }

    }
}
