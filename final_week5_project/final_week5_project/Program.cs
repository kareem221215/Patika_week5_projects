using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace final_week5_project
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool another_car = true;

            List<Car> cars = new List<Car>();

            while (another_car)
            {

                string serialNumber;
                while (true) // make sure serial number is in the correct form of 2 numbers 3 letters then 3 numbers
                {
                    Console.WriteLine("Please enter a serial number (2 integers, 3 letters, 3 integers, e.g., 12ABC345):");
                    serialNumber = Console.ReadLine();

                    // Regular expression to match the serial number format
                    string pattern = @"^\d{2}[A-Za-z]{3}\d{3}$";
                    if (Regex.IsMatch(serialNumber, pattern))
                    {
                        break; // Valid serial number, exit loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid serial number format. Please try again.");
                    }
                }

                Console.WriteLine("Please enter the Brand:"); // enter brand name
                string brand = Console.ReadLine();

                Console.WriteLine("Please enter the Model:");// enter model name
                string model = Console.ReadLine();

                Console.WriteLine("Please enter the Color:"); // enter car color
                string color = Console.ReadLine();

                int numberOfDoors;


                while (true) // validate numbers of doors are either 2 or 4
                {
                    Console.WriteLine("Please enter the Number of Doors (2/4):");
                    if (int.TryParse(Console.ReadLine(), out numberOfDoors) && (numberOfDoors == 2 || numberOfDoors == 4))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number of doors.");
                    }
                }

                Car car = new Car(serialNumber, brand, model, color, numberOfDoors); // make car object
                cars.Add(car); // add to the list

                Console.WriteLine("Would you like to make another car (Y/N)?"); // ask if user wants to make another car
                string response = Console.ReadLine().ToLower();
                another_car = response == "y";      

            }
            Console.WriteLine("\nList of all cars:"); // print car from the list
            foreach (var car in cars)
            {
                Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}, Model: {car.Model}, Color: {car.Color}, Doors: {car.NoOfDoors}, Production Date: {car.DateTime}");
            }
        }
    }
}
