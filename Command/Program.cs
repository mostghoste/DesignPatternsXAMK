namespace Command
{
    public interface ICommand
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