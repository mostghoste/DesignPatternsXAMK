using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
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
}
