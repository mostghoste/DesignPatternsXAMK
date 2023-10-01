using BuilderExercise.Models;

namespace BuilderExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the house construction company!");
            Console.WriteLine("Please select a type of house you'd like to build:");
            Console.WriteLine("1: Wooden House");
            Console.WriteLine("2: Brick House");
            Console.WriteLine("3: Custom House");

            string choice = Console.ReadLine();

            var company = new ConstructionCompany();
            HouseBuilder builder;

            switch (choice)
            {
                case "1":
                    builder = new WoodHouseBuilder();
                    break;
                case "2":
                    builder = new BrickHouseBuilder();
                    break;
                case "3":
                    builder = new CustomHouseBuilder();
                    break;
                default:
                    Console.WriteLine("Invalid choice! Building a default Wooden House.");
                    builder = new WoodHouseBuilder();
                    break;
            }

            House house = company.ConstructHouse(builder);
            Console.WriteLine($"Your {builder.GetType().Name.Replace("Builder", "")} is ready:");
            Console.WriteLine(house.ToString());
        }
    }
}