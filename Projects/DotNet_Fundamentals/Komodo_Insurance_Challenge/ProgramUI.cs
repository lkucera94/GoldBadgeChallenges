using System;
using System.Collections.Generic;

namespace Komodo_Insurance_Challenge
{
    public class ProgramUI
    {
        private CustomerInformation _customer;
        private VehicleRepository _vehicleRepo;

        public ProgramUI()
        {
            _customer = new CustomerInformation();
            _vehicleRepo = new VehicleRepository();
        }

        public void Run()
        {
            Register();

            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine($"Hello {_customer.Name}\n" +
                    "What would you like to do?\n" +
                    "1. View Information\n" +
                    "2. Update Information\n" +
                    "3. Register Vehicle\n" +
                    "4. Exit");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        ViewInformation();
                        break;
                    case 2:
                        Register();
                        break;
                    case 3:
                        RegisterVehicle();
                        break;
                    case 4:
                        running = false;
                        break;

                }
            }
        }

        private void RegisterVehicle()
        {
            Console.WriteLine("Enter the make of your vehicle:");
            string make = Console.ReadLine();

            Console.WriteLine("Enter the model of your vehicle:");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the year of your vehicle:");
            string yearAsString = Console.ReadLine();
            int year = int.Parse(yearAsString);

            Console.WriteLine("Enter the mileage of your vehicle:");
            string mileageAsString = Console.ReadLine();
            int mileage = int.Parse(mileageAsString);



            VehicleInformation newVehicle = new VehicleInformation(make, model, year, mileage);
            _vehicleRepo.AddVehicleToList(newVehicle);
        }

        private void ViewInformation()
        {
            List<VehicleInformation> list = _vehicleRepo.GetVehicleList();

            decimal total = 0;

            //foreach (variableType variableName in collectionName)
            foreach(VehicleInformation vehicle in list)
            {
                decimal premium = _vehicleRepo.CalculatePremium(vehicle);
                total = total + premium; //total += premium;

                Console.WriteLine($"{vehicle.Year} {vehicle.Make} {vehicle.Model} ${premium}");

            }
            if(_customer.Age >= 25)
            {
                total += 75;
            }
            else
            {
                total += 125;
            }

            Console.WriteLine($"Your total cost is ${total}");
            Console.ReadKey();
        }

        private void Register()
        {
            Console.WriteLine("Enter your full name:");
            _customer.Name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            string ageAsString = Console.ReadLine();
            _customer.Age = int.Parse(ageAsString);

            Console.WriteLine("Enter your gender:\n" +
                " 1)Male 2)Female 3) Other ");
            string genderAsString = Console.ReadLine().ToLower();
            switch (genderAsString)
            {
                case "male":
                case "1":
                    _customer.Gender = GenderType.Male;
                    break;
                case "female":
                case "2":
                    _customer.Gender = GenderType.Female;
                    break;
                case "other":
                case "3":
                default:
                    _customer.Gender = GenderType.Other;
                    break;
            }


        }
    }
}