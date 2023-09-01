using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath
{
    /// <summary>
    /// Name: Francis Sullivan
    /// Student ID: 30034007
    /// Date: 2023.08.29
    /// Description: This DLL provides calculation services with the four following astronomical functions: 
    /// Star Velocity, Star Distance, Temperature Conversion and Blackhole Event Horizon.
    /// </summary>
    public class AstronomicalFunctions
    {
        /// <summary>
        /// Calculate Star Velocity.
        /// Formula used: v = c ( Δλ / λo )
        /// Warning! This method contains no error trapping, and will not catch division by zero errors. 
        /// Error trapping must be implemented on the client side.
        /// </summary>
        /// <param name="observedWavelengthInNanoMetres">Input a double value representing the observed wavelength of the body in nano metres.</param>
        /// <param name="restWavelengthInNanoMetres">Input a double value representing the rest wavelength of the body in nano metres.</param>
        /// <returns>Returns a double value representing the velocity of the body in metres per second.</returns>
        public double StarVelocity(double observedWavelengthInNanoMetres, double restWavelengthInNanoMetres)
        {
            double observedWavelengthInMetres = observedWavelengthInNanoMetres / 1000000.0;
            double restWavelengthInMetres = restWavelengthInNanoMetres / 1000000.0;
            double changeInWavelengthInMetres = observedWavelengthInMetres - restWavelengthInMetres;
            double speedOfLightInMetresPerSecond = 299792458;
            double velocityInMetresPerSecond = speedOfLightInMetresPerSecond * (changeInWavelengthInMetres / restWavelengthInMetres);
            return velocityInMetresPerSecond;
        }
        /// <summary>
        /// Convert Celsius to Kelvin.
        /// Formula used: K = C + 273.15
        /// Warning! This method contains no error trapping, and will not catch non-existent temperatures such as those below absolute zero. 
        /// Error trapping must be implemented on the client side.
        /// </summary>
        /// <param name="temperatureInCelsius">Input a double value representing the temperature in celsius that you wish to convert to kelvin.</param>
        /// <returns>Returns a double value representing your temperature in kelvin.</returns>
        public double TemperatureConversion(double temperatureInCelsius)
        {
            double temperatureInKelvin = temperatureInCelsius + 273.15;
            return temperatureInKelvin;
        }
        /// <summary>
        /// Calculate Star Distance.
        /// Formula used: D = 1 / P
        /// Warning! This method contains no error trapping, and will not catch division by zero errors. 
        /// Error trapping must be implemented on the client side.
        /// </summary>
        /// <param name="paralaxAngleInArcseconds">Input a double value representing the parallax angle of the body in arcseconds.</param>
        /// <returns>Returns a double value representing the distance to the body in parsecs.</returns>
        public double StarDistance(double paralaxAngleInArcseconds)
        {
            double distanceInParsecs = 1 / paralaxAngleInArcseconds;
            return distanceInParsecs;
        }
        /// <summary>
        /// Calculate Blackhole Schwarzschild Radius.
        /// Formula used: R = ( 2GM ) / c^2
        /// </summary>
        /// <param name="blackHoleMassInKilograms">Input a double value representing the mass of the body you wish to calculate for in kilograms.</param>
        /// <returns>Returns a double value representing the Schwarzschild Radius of the body in metres.</returns>
        public double BlackholeEventHorizon(double blackHoleMassInKilograms)
        {
            double speedOfLightInMetresPerSecond = 299792458;
            double gravitationalConstant = 6.674 * Math.Pow(10, -11);
            double schwarzschildRadiusInMetres = (2.0 * gravitationalConstant * blackHoleMassInKilograms) / (speedOfLightInMetresPerSecond * speedOfLightInMetresPerSecond);
            return schwarzschildRadiusInMetres;
        }
    }
}
