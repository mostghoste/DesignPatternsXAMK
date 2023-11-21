namespace Command
{
    public interface ICommand
    {
        void execute();
    }

    public class Light
    {
        void on()
        {
            Console.WriteLine("Light is on");
        }
        void off()
        {
            Console.WriteLine("Light is off");
        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}