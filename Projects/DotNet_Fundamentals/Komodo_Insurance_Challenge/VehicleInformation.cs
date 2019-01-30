using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Challenge
{
   public class VehicleInformation
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage{ get; set; }

        public VehicleInformation() { }

        public VehicleInformation(string make, string model, int year, int mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
    }
}
