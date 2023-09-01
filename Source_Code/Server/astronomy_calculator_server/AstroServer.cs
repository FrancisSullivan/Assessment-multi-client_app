using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using AstroMath;

namespace astronomy_calculator_server
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        AstronomicalFunctions astronomicalFunctions = new AstronomicalFunctions();

        // Calculate Star Velocity.
        public double StarVelocity(double observedWavelengthInNanoMetres, double restWavelengthInNanoMetres)
        {
            return astronomicalFunctions.StarVelocity(observedWavelengthInNanoMetres, restWavelengthInNanoMetres);
        }

        // Convert Celsius to Kelvin.
        public double TemperatureConversion(double temperatureInCelsius)
        {
            return astronomicalFunctions.TemperatureConversion(temperatureInCelsius);
        }

        // Calculate Star Distance.
        public double StarDistance(double paralaxAngleInArcseconds)
        {
            return astronomicalFunctions.StarDistance(paralaxAngleInArcseconds);
        }

        // Calculate Blackhole Schwarzschild Radius.
        public double BlackholeEventHorizon(double blackHoleMassInKilograms)
        {
            return astronomicalFunctions.BlackholeEventHorizon(blackHoleMassInKilograms);
        }
    }
}
