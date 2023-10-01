namespace BuilderExercise.Models
{
    public class CustomHouseBuilder : HouseBuilder
    {
        public override void BuildFoundation()
        {
            Console.WriteLine("Choose a foundation type:");
            // I think it could be cool to implement a way to gather the foundation options dynamically.
            // (Analyse all the existing builders and provide the options from them)
            // But all the implementations I can think of are out of the scope of the exercise.
            Console.WriteLine("1 - Wood foundation");
            Console.WriteLine("2 - Brick foundation");
            string? choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    // This feels hacky. Ideally there should be a way to return the same result as
                    // the WoodHouseBuilder BuildFoundation() method does.
                    house.Foundation = "Wooden foundation";

                    // Perhaps something like this?
                    // Create a temporary builder to get the result of a proper builder, and then apply the result
                    // to the current house

                    //HouseBuilder tempBuilder = new WoodHouseBuilder();
                    //tempBuilder.BuildFoundation();
                    //house.Foundation = tempBuilder.GetHouse().Foundation;
                    break;
                case "2":
                    house.Foundation = "Brick foundation";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to wood.");
                    house.Foundation = "Wooden foundation";
                    break;
            }
        }
        public override void BuildWalls()
        {
            Console.WriteLine("Choose a wall type:");
            Console.WriteLine("1 - Wood wall");
            Console.WriteLine("2 - Brick wall");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    house.Walls = "Wooden walls";
                    break;
                case "2":
                    house.Walls = "Brick walls";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to wood.");
                    house.Walls = "Wooden walls";
                    break;
            }
        }
        public override void BuildRoof()
        {
            Console.WriteLine("Choose a roof type:");
            Console.WriteLine("1 - Wood roof");
            Console.WriteLine("2 - Brick roof");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    house.Roof = "Wooden roof";
                    break;
                case "2":
                    house.Roof = "Brick roof";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to wood.");
                    house.Roof = "Wooden roof";
                    break;
            }
        }

        public override void BuildGarage()
        {
            Console.WriteLine("Should the house have a garage?:");
            Console.WriteLine("1 - Yes, the house should have a garage.");
            Console.WriteLine("2 - No, the house should not have a garage.");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    house.HasGarage = true;
                    break;
                case "2":
                    house.HasGarage= false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to 1.");
                    house.HasGarage = true;
                    break;
            }
        }

        public override void BuildGarden()
        {
            Console.WriteLine("Should the house have a garden?:");
            Console.WriteLine("1 - Yes, the house should have a garden.");
            Console.WriteLine("2 - No, the house should not have a garden.");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    house.HasGarden = true;
                    break;
                case "2":
                    house.HasGarden = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to 1.");
                    house.HasGarden = true;
                    break;
            }
        }

        public override void BuildSwimmingPool()
        {
            Console.WriteLine("Should the house have a swimming pool?:");
            Console.WriteLine("1 - Yes, the house should have a swimming pool.");
            Console.WriteLine("2 - No, the house should not have a swimming pool.");
            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    house.HasSwimmingPool = true;
                    break;
                case "2":
                    house.HasSwimmingPool = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting to 1.");
                    house.HasSwimmingPool = true;
                    break;
            }
        }
    }
}
