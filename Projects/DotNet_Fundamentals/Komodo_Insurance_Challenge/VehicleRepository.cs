using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Challenge
{
    public class VehicleRepository
    {
        private List<VehicleInformation> _vehicleList = new List<VehicleInformation>();

        public void AddVehicleToList(VehicleInformation newVehicle)
        {
            _vehicleList.Add(newVehicle);
        }

        public List<VehicleInformation> GetVehicleList()
        {
            return _vehicleList;
        }

        public decimal CalculatePremium(VehicleInformation vehicle)
        {
            decimal premium = 0;
            if(vehicle.Mileage >= 50000 && vehicle.Mileage < 100000)
            {
                premium = 25.00m;
            }
            else if (vehicle.Mileage > 100000)
            {
                premium = 50.00m;
            }
            return premium;


        }  
    }
}
