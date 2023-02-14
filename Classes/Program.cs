namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           Car koolCar  = new Car();            //Create new instance of the Car class
            koolCar.Make = "Tesla";
            koolCar.Model = "Model X";
            koolCar.Year = 2022;

            Console.WriteLine($"{koolCar.Make} {koolCar.Model} {koolCar.Year} is coolest car on the road");
        }
    }
}
