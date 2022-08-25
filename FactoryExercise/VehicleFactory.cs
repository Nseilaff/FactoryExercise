using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryExercise
{
    internal static class VehicleFactory
    {
        public static IVehicle CreateVehicle(int numOfWheels, string type)
        {
            switch (numOfWheels)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    if (type == "yes")
                    {
                        return new SportsCar();
                    }
                    else return new Car();
                case 6:
                    return new FarmTruck();
                default:
                    return new Car();
            }

        }

    }
}
