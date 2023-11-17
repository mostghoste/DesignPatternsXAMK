namespace Strategy
{
    public interface Bird
    {
        string name { get; set; }
        MoveStrategy moveStrategy { get; set; }

        void move();
        void setStrategy(MoveStrategy moveStrategy);
    }

    public interface MoveStrategy
    {
        void execute();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}