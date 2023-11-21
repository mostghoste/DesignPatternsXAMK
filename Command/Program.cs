namespace Command
{
    public interface ICommand
    {
        void execute();
    }

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

    public class RemoteController
    {
        ICommand slot;

        public RemoteController() {}

        public void setCommand(ICommand command)
        {
            slot = command;
        }
        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteController remote = new RemoteController();
            Light light = new Light();
            LightOnCommand lightOn = new LightOnCommand(light);
            remote.setCommand(lightOn);
            remote.buttonWasPressed();
        }
    }
}