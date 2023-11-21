using System.Text;

namespace Command
{
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

    // Light class and its commands
    public class Light
    {
        public void on()
        {
            Console.WriteLine("Light is on");
        }
        public void off()
        {
            Console.WriteLine("Light is off");
        }
    }

    public class LightOnCommand : ICommand
    {
        Light light;

        //The constructor is passed the specific instance of the light it is going to control
        public LightOnCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.on();
        }
    }

    public class LightOffCommand : ICommand
    {
        Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void execute()
        {
            light.off();
        }
    }

    // Thermostat class and its commands
    public class Thermostat
    {
        int currentTemperature;

        public Thermostat()
        {
            currentTemperature = 20;
        }

        public void increaseTemperature()
        {
            if (currentTemperature == 30)
            {
                Console.WriteLine("This is a thermostat, not a barbecue.");
                return;
            }
            currentTemperature += 1;
            Console.WriteLine("Temperature increased to " + currentTemperature);
        }

        public void decreaseTemperature()
        {
            if (currentTemperature == -15)
            {
                Console.WriteLine("Are you trying to freeze us to death?");
                return;
            }
            currentTemperature -= 1;
            Console.WriteLine("Temperature decreased to " + currentTemperature);
        }
    }

    public class IncreaseTemperatureCommand : ICommand
    {
        Thermostat thermostat;

        public IncreaseTemperatureCommand(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }

        public void execute()
        {
            thermostat.increaseTemperature();
        }
    }

    public class DecreaseTemperatureCommand : ICommand
    {
        Thermostat thermostat;

        public DecreaseTemperatureCommand(Thermostat thermostat)
        {
            this.thermostat = thermostat;
        }

        public void execute()
        {
            thermostat.decreaseTemperature();
        }
    }

    // Composite commands
    public class IncreaseTemperatureAndLightOnCommand : ICommand
    {
        Thermostat thermostat;
        Light light;

        public IncreaseTemperatureAndLightOnCommand(Thermostat thermostat, Light light)
        {
            this.thermostat = thermostat;
            this.light = light;
        }

        public void execute()
        {
            thermostat.increaseTemperature();
            light.on();
        }
    }

    public class DecreaseTemperatureAndLightOffCommand : ICommand
    {
        Thermostat thermostat;
        Light light;

        public DecreaseTemperatureAndLightOffCommand(Thermostat thermostat, Light light)
        {
            this.thermostat = thermostat;
            this.light = light;
        }

        public void execute()
        {
            thermostat.decreaseTemperature();
            light.off();
        }
    }

    public class RemoteController
    {
        ICommand[] slot;

        public RemoteController()
        {
            // Our remote is going to have six slots for commands
            slot = new ICommand[6];
            // Fill the remote with no commands
            for (int i = 0; i < slot.Length; i++)
            {
                slot[i] = new NoCommand();
            }
        }

        public void setCommand(int remoteButtonIndex,  ICommand command)
        {
            slot[remoteButtonIndex] = command;
        }
        public void buttonWasPressed(int remoteButtonIndex)
        {
            slot[remoteButtonIndex].execute();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("------ Remote Control Buttons -------\n");
            for (int i = 0; i < slot.Length; i++)
            {
                sb.Append("[slot " + i + "] " + slot[i].GetType().Name + "\n");
            }
            sb.Append("--------------------------------------");
            return sb.ToString();
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
            RemoteController remote = new RemoteController();
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
                    string input = Console.ReadLine();
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