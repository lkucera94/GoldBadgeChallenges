using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string TypeOfVehicle { get; set; }
        public string Color { get; set; }
        public byte Wheels { get; set; }
        public bool HadAccidents { get; set; }
        public int Owners { get; set; }

        public Car(string brand, string model, int year, string typeOfVehicle, string color, byte wheels, bool hadAccidents, int owners)
        {
            Brand = brand;
            Model = model;
            Year = year;
            TypeOfVehicle = typeOfVehicle;
            Color = color;
            Wheels = wheels;
            HadAccidents = hadAccidents;
            Owners = owners;

        }
        public Car()
        {

        }
    }
}
