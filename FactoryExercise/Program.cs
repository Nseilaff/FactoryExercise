
using FactoryExercise;

string isCar = "";

Console.WriteLine("How many wheels would you like your new car to have?");

var answer = int.Parse(Console.ReadLine());
if (answer == 4)
{
    Console.WriteLine("Is your vehicle a sports car");
    isCar = Console.ReadLine();
}
var response = VehicleFactory.CreateVehicle(answer, isCar);

response.Drive();