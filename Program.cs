using System.Diagnostics.CodeAnalysis;

namespace Properties_Brown_Jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {   //makes a new game obj from the car class
            Car car = new Car();
            //sets the make of the frist car
            car.Make = "ford";
            //sets the model of the frist car
            car.Model = "mustang";
            //Tells the user make and model of the first car
            Console.WriteLine($"Make: {car.Make} \nModle: {car.Model}\n");
            //makes a new game obj from the car class
            Car car2 = new Car();
            //sets the make of the second car
            car2.Make = "Chevy";
            //sets the model of the second car
            car2.Model = "Camero";
            //Tells the user make and model of the second car
            Console.WriteLine($"Make: {car2.Make} \nModle: {car2.Model}");
        }
    }
}
