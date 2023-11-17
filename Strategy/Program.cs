namespace Strategy
{
    public abstract class Bird
    {
        public abstract string name { get; set; }
        public abstract MoveStrategy moveStrategy { get; set; }

        public abstract void Move();
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

    public class Sparrow : Bird
    {
        public override string name { get; set; }
        public override MoveStrategy moveStrategy { get; set; }

        public Sparrow(MoveStrategy moveStrategy)
        {
            name = "Sparrow";
            this.moveStrategy = moveStrategy;
        }
        public override void Move()
        {
            Console.Write(name + " movement: ");
            moveStrategy.execute();
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

            // Initialise the list of birds with default values
            List<Bird> birdList = new List<Bird> { sparrow };

            // Make every bird in the list move
            foreach (Bird bird in birdList)
            {
                bird.Move();
            }
        }
    }
}