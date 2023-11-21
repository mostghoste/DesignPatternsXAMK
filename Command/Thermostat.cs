using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
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
}
