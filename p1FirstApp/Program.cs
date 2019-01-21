using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Double rides;
            var vehicleType = "";
            Double totalCost;
            Double miles;
            var ans = "";
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("***********************Welcome to Ride Cost Calculator*****************************");


            while (ans != "n")
            {
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("\nEnter the number of rides: \t");
                var input = Console.ReadLine();
                rides = Convert.ToDouble(input);
                if (rides != 0)
                {

                    Console.WriteLine("Select vehicle type ('car','bike','shareBus') only ");
                    Console.WriteLine(" car - $10/mile \n bike- $2/mile \n shareBus - $5/mile");
                    vehicleType = Console.ReadLine();
                    Console.WriteLine("\t Enter number of miles\t");
                    miles = Convert.ToDouble(Console.ReadLine());


                    switch (vehicleType)
                    {
                        case "car":
                            {
                                totalCost = CostCalc(miles,rides);
                                Console.WriteLine($"\tCost for 1 ride is : ${10 * miles}");
                                Console.WriteLine($"\tTotal cost for {rides} rides in a {vehicleType} is:  ${10 * totalCost}\n");
                                
                                break;
                            }
                        case "bike":
                            {
                                totalCost = CostCalc(miles, rides);
                                Console.WriteLine($"\tCost for 1 ride is : ${2 * miles}");
                                Console.WriteLine($"\tTotal cost for {rides} rides on a {vehicleType} is:  ${2 * totalCost}\n");
                                break;
                            }
                        case "shareBus":
                            {
                                totalCost = CostCalc(miles, rides);
                                Console.WriteLine($"\tCost for 1 ride is : ${5 * miles}");
                                Console.WriteLine($"\tTotal cost for {rides} rides in a {vehicleType} is:  ${5 * totalCost}\n");
                                break;
                            }
                        default:
                            Console.WriteLine("Vehicle type invalid!!! (Enter 'car' || 'bike' | |'bus' only )\n");
                            break;
                    }



                }
                else
                {
                    Console.WriteLine("Number of Rides cannot be 0");


                }

                Console.WriteLine("DO you want to start again?? (enter 'y' for yes 'n' for no)");
                ans = Console.ReadLine();

            }






            //  Declare and use a bool, int, double, char, string, and decimal type.


            //  Implement at least one loop
            //  Implement at least one if or if-else branch with conditions
            //Implement a switch statement
            //Implement a simple function calculation(e.g.totalCost or hasEnough)
            //Use Console.WriteLine and Console.ReadLine
            //Use string interpolation($"") and \n or \t
        }

        static Double CostCalc(Double miles, Double rides)
        {
            Double result;
            result = miles * rides;
            return result;
        }
    }
}

