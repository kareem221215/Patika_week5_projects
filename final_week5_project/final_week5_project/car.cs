using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_week5_project
{
    public class Car 
    {
        public DateTime DateTime {  get; private set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color {  get; set; }
        public int NoOfDoors { get; set; }
        public Car(string serialNumber, string brand, string model, string color, int noOfDoors)
        {
            DateTime = DateTime.Now;
            SerialNumber = serialNumber;
            Brand = brand;
            Model = model;
            Color = color;
            NoOfDoors = noOfDoors;
        }
    }

}
