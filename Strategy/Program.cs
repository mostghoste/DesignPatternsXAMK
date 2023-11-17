namespace Strategy
{
    public abstract class Bird
    {
        public abstract string name { get; set; }
        public abstract MoveStrategy moveStrategy { get; set; }

        public void Move()
        {
            Console.Write(name + " movement: ");
            moveStrategy.execute();
        }
        public abstract void SetStrategy(MoveStrategy moveStrategy);
    }

    public interface MoveStrategy
    {
        void execute();
    }

    public class FlyStrategy : MoveStrategy
    {
        public void execute()
        {
            Console.WriteLine("Flaps its wings and soars through the air!");
        }
    }
    public class SwimStrategy : MoveStrategy
    {
        public void execute()
        {
            Console.WriteLine("Uses its little feet to propel itself in the water!");
        }
    }
    public class RunStrategy : MoveStrategy
    {
        public void execute()
        {
            Console.WriteLine("Uses its magnificent legs to walk on the land!");
        }
    }

    public class Sparrow : Bird
    {
        public override string name { get; set; }
        public override MoveStrategy moveStrategy { get; set; }

        public Sparrow(MoveStrategy moveStrategy)
        {
            name = "Sparrow";
            this.moveStrategy = moveStrategy;
        }

        public override void SetStrategy(MoveStrategy moveStrategy)
        {
            this.moveStrategy = moveStrategy;
        }
    }

    public class Penguin : Bird
    {
        public override string name { get; set; }
        public override MoveStrategy moveStrategy { get; set; }

        public Penguin(MoveStrategy moveStrategy)
        {
            name = "Penguin";
            this.moveStrategy = moveStrategy;
        }

        public override void SetStrategy(MoveStrategy moveStrategy)
        {
            this.moveStrategy = moveStrategy;
        }
    }

    public class Ostrich : Bird
    {
        public override string name { get; set; }
        public override MoveStrategy moveStrategy { get; set; }

        public Ostrich(MoveStrategy moveStrategy)
        {
            name = "Ostrich";
            this.moveStrategy = moveStrategy;
        }

        public override void SetStrategy(MoveStrategy moveStrategy)
        {
            this.moveStrategy = moveStrategy;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create all the different types of birds
            Bird sparrow = new Sparrow(new FlyStrategy());
            Bird penguin = new Penguin(new SwimStrategy());
            Bird ostrich = new Ostrich(new RunStrategy());

            // Initialise the list of birds with default values
            List<Bird> birdList = new List<Bird> { sparrow, penguin, ostrich };

            // Make every bird in the list move
            foreach (Bird bird in birdList)
            {
                bird.Move();
            }

            // Display the capability of changing movement strategy at runtime
            Console.WriteLine("\nLooks like the penguin has reached the shore!");
            penguin.SetStrategy(new RunStrategy());
            penguin.Move();
        }
    }
}