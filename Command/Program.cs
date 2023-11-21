using System.Text;

namespace Command
{
    // Should I move these out of this file? Probably.
    public interface ICommand
    {
        void execute();
    }

    public class NoCommand : ICommand
    {
        public void execute()
        {
            Console.WriteLine("Nothing happens.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a light and its commands
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            LightOffCommand lightOff = new LightOffCommand(light);

            // Create a thermostat and its commands
            Thermostat thermostat = new Thermostat();
            IncreaseTemperatureCommand increaseTemperature = new IncreaseTemperatureCommand(thermostat);
            DecreaseTemperatureCommand decreaseTemperature = new DecreaseTemperatureCommand(thermostat);

            // Create composite commands
            IncreaseTemperatureAndLightOnCommand increaseTemperatureAndLightOn = new IncreaseTemperatureAndLightOnCommand(thermostat, light);
            DecreaseTemperatureAndLightOffCommand decreaseTemperatureAndLightOff = new DecreaseTemperatureAndLightOffCommand(thermostat, light);
            
            // Create a remote controller and set it's commands
            RemoteController remote = new RemoteController(8);
            remote.setCommand(0, lightOn);
            remote.setCommand(1, lightOff);
            remote.setCommand(2, increaseTemperature);
            remote.setCommand(3, decreaseTemperature);
            remote.setCommand(4, increaseTemperatureAndLightOn);
            remote.setCommand(5, decreaseTemperatureAndLightOff);

            // Print the commands of the remote controller
            Console.WriteLine(remote.ToString());

            // Main command reading loop
            while (true)
            {
                Console.WriteLine("\nEnter a command number or write 'exit': ");
                // Try to convert the input to a command number. Handle the exception if the input is not a number
                try
                {
                    string? input = Console.ReadLine();
                    if (input == "exit")
                    {
                        break;
                    }
                    int commandNumber = Convert.ToInt32(input);
                    remote.buttonWasPressed(commandNumber);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a valid command number.");
                    continue;
                }
            }
        }
    }
}