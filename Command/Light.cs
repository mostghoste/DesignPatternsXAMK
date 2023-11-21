using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    // Light class and its commands
    public class Light
    {
        bool isOn;

        public Light()
        {
            isOn = false;
        }
        public void on()
        {
            if (isOn)
            {
                Console.WriteLine("Light is already on");
                return;
            }
            isOn = true;
            Console.WriteLine("Light is on");
        }
        public void off()
        {
            if (!isOn)
            {
                Console.WriteLine("Light is already off");
                return;
            }
            isOn = false;
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
}
