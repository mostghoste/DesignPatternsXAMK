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

            // Create a remote controller and set it's commands
            RemoteController remote = new RemoteController();
            remote.setCommand(0, lightOn);
            remote.setCommand(1, lightOff);

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