using System;
/*Shane Trentham
 Assignment 02
 9/13/2018
 Dr. Church
 CSCI 3005*/

namespace TrenthamAssign03
{
    class Program
    {
        public

        static void Main(string[] args)
        {
            Dignity dignity = new Dignity();
            DragonBuilder builder = new DragonBuilder();
            string choice = "";

            while (choice != "7")
            {
                Console.WriteLine("\n\nThis Program is case specific!" +
                             "1. Add a dragon \n" +
                             "2. Get number of dragons in the dignity\n" +
                             "3. Find the largest dragon\n" +
                             "4. Find the largest dragon of a type\n" +
                             "5. Get the count of good\n" +
                             "6. Get the count of bad dragons\n" +
                             "7. Quit");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        builder.BuildDragon();
                        dignity.AddDragon(builder.GetDragon());
                        break;
                    case "2":
                        Console.WriteLine($"There are {dignity.Count()} dragons in the dignity.");
                        break;
                    case "3":
                        Dragon dragon = dignity.GetLargest();
                        Console.WriteLine($"The largest dragon is: {dragon.ToString()}");
                        break;
                    case "4":
                        Console.WriteLine("Enter the type of dragon you are looking for: ");
                        string type = Console.ReadLine();
                        Dragon dragonType = dignity.GetLargestofType(type);
                        Console.WriteLine($"The largest dragon of type {type} is {dragonType.ToString()}");
                        break;
                    case "5":
                        Console.WriteLine($"There are {dignity.GetGood()} good dragons in the dignity.");
                        break;
                    case "6":
                        Console.WriteLine($"There are {dignity.GetBad()} bad dragons in the dignity.");
                        break;
                    case "7":
                        Console.WriteLine("Program ending...");
                        System.Environment.Exit(0);
                        break;

                }
            }

        }

        public void GetDragon()
        {
            Console.WriteLine();
        }
    }
}
