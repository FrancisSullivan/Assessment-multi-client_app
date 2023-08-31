using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace astronomy_calculator_client
{
    [ServiceContract]
    internal interface IAstroContract
    {
        // Calculate Star Velocity.
        [OperationContract]
        double StarVelocity(double observedWavelengthInNanoMetres, double restWavelengthInNanoMetres);

        // Convert Celsius to Kelvin.
        [OperationContract]
        double TemperatureConversion(double temperatureInCelsius);

        // Calculate Star Distance.
        [OperationContract]
        double StarDistance(double paralaxAngleInArcseconds);


        // Calculate Blackhole Schwarzschild Radius.
        [OperationContract]
        double BlackholeEventHorizon(double blackHoleMassInKilograms);
    }
}
