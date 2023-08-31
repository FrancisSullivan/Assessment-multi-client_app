using AstroMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstroMath_DLL_Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the DLL's AstronomicalFunctions class.
            AstronomicalFunctions astronomicalFunctions = new AstronomicalFunctions();
            // Print Title.
            Console.WriteLine("DLL Test Program\n");
            // Main loop of program.
            while (true)
            {
                // Prompt user for their selection.
                Console.WriteLine(
                    "Select the DLL method you wish to test:\n" +
                    "   1. Temperature Conversion\n" +
                    "   2. Star Distance\n" +
                    "   3. Star Velocity\n" +
                    "   4. Blackhole Event Horizon\n"
                    );
                string input = Console.ReadLine();
                // Manage selection with switch case.
                switch (input)
                {
                    // Temperature Conversion.
                    case "1":
                        // Prompt user for DLL input.
                        Console.Write("Input a numerical value representing the temperature in celsius that you wish to convert to kelvin: ");
                        try 
                        { 
                            // Parse input to a double.
                            double dllInput = double.Parse(Console.ReadLine());
                            try
                            {
                                // Pass to DLL.
                                double dllOutput = astronomicalFunctions.TemperatureConversion(dllInput);
                                // Print raw output.
                                Console.WriteLine("DLL raw output: " + dllOutput);
                                // Print formatted output.
                                Console.WriteLine("DLL output with post formatting: " + dllOutput + " °K");
                            }
                            // Catch any problems with the DLL.
                            catch { Console.WriteLine("DLL processing error."); }
                        }
                        // Catch non-numeric inputs.
                        catch { Console.WriteLine("Error: Input was non-numeric please try again."); }
                        break;
                    // Star Distance.
                    case "2":
                        Console.Write("Input a numerical value representing the parallax angle of the body in arcseconds: ");
                        try
                        {
                            // Parse input to a double.
                            double dllInput = double.Parse(Console.ReadLine());
                            try
                            {
                                // Pass to DLL.
                                double dllOutput = astronomicalFunctions.StarDistance(dllInput);
                                // Print raw output.
                                Console.WriteLine("DLL raw output: " + dllOutput);
                                // Print formatted output.
                                Console.WriteLine("DLL output with post formatting: " + string.Format("{0:0.##}", dllOutput) + " pc");
                            }
                            // Catch any problems with the DLL.
                            catch { Console.WriteLine("DLL processing error."); }
                        }
                        // Catch non-numeric inputs.
                        catch { Console.WriteLine("Error: Input was non-numeric please try again."); }
                        break;
                    // Star Velocity.
                    case "3":
                        try
                        {
                            // Parse inputs to a double.
                            Console.Write("Input a numerical value representing the observed wavelength of the body in nano metres: ");
                            double dllInput1 = double.Parse(Console.ReadLine());
                            Console.Write("Input a numerical value representing the rest wavelength of the body in nano metres: ");
                            double dllInput2 = double.Parse(Console.ReadLine());
                            try
                            {
                                // Pass to DLL.
                                double dllOutput = astronomicalFunctions.StarVelocity(dllInput1, dllInput2);
                                // Print raw output.
                                Console.WriteLine("DLL raw output: " + dllOutput);
                                // Print formatted output.
                                Console.WriteLine("DLL output with post formatting: " + string.Format("{0:0.##E+00}", dllOutput) + " m/s");
                            }
                            // Catch any problems with the DLL.
                            catch { Console.WriteLine("DLL processing error."); }
                        }
                        // Catch non-numeric inputs.
                        catch { Console.WriteLine("Error: Input was non-numeric please try again."); }
                        break;
                    // Blackhole Event Horizon.
                    case "4":
                        Console.Write("Input a numerical value representing the mass of the body you wish to calculate for in kilograms: ");
                        try
                        {
                            // Parse input to a double.
                            double dllInput = double.Parse(Console.ReadLine());
                            try
                            {
                                // Pass to DLL.
                                double dllOutput = astronomicalFunctions.BlackholeEventHorizon(dllInput);
                                // Print raw output.
                                Console.WriteLine("DLL raw output: " + dllOutput);
                                // Print formatted output.
                                Console.WriteLine("DLL output with post formatting: " + string.Format("{0:0.##E+00}", dllOutput) + " m");
                            }
                            // Catch any problems with the DLL.
                            catch { Console.WriteLine("DLL processing error."); }
                        }
                        // Catch non-numeric inputs.
                        catch { Console.WriteLine("Error: Input was non-numeric please try again."); }
                        break;
                    // Prints if the user's choice is not listed in the switch case.
                    default:
                        Console.WriteLine("No valid selection has been detected, please try again.");
                        break;
                }
                Console.WriteLine("Press any key to continue: ");
                Console.ReadLine();
            }   
        }
    }
}
