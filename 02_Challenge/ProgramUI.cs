using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    class ProgramUI
    {
        private Queue<Claim> _claim;
        private ClaimRepository _claimRepo;

        public ProgramUI()
        {
            _claimRepo = new ClaimRepository();
            _claim = _claimRepo.GetClaims();
            Claim claim = new Claim();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add a claim\n" +
                    "2. View claims\n" +
                    "3. Take care of next claim\n" +
                    "4. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:
                        AddClaim();
                        break;
                    case 2:
                        ViewClaims();
                        break;
                    case 3:
                        RemoveClaim();
                        break;
                    case 4:
                        running = false;
                        break;
                }
            }
        }
        private void AddClaim()
        {
            Claim newCLaim = new Claim();

            Console.WriteLine("What is the Claim ID?");
            string inputAsString = Console.ReadLine();
            newCLaim.ClaimID = int.Parse(inputAsString);

            Console.WriteLine("What is the claim type?\n" +
                "1. Car\n" +
                "2. Home\n" +
                "3. Theft");
            string typeAsString = Console.ReadLine().ToLower();
            switch (typeAsString)
            {
                case "1":
                case "car":
                    newCLaim.Type = ClaimType.Car;
                    break;
                case "2":
                case "home":
                    newCLaim.Type = ClaimType.Home;
                    break;
                case "3":
                case "theft":
                    newCLaim.Type = ClaimType.Theft;
                    break;
            }
            Console.WriteLine("What is the claim description?");
            newCLaim.Description = Console.ReadLine();

            Console.WriteLine("What is the claim amount?");
            string claimAmount = Console.ReadLine();
            newCLaim.Amount = decimal.Parse(claimAmount);

            Console.WriteLine("What is the date of the incident? mm/dd/yyyy");
            string dateOfIncident = Console.ReadLine();
            newCLaim.DateOfAccident = DateTime.Parse(dateOfIncident);

            Console.WriteLine("What is the date of the claim? mm/dd/yyyy");
            string dateOfClaim = Console.ReadLine();
            newCLaim.DateOfClaim = DateTime.Parse(dateOfClaim);

            Console.WriteLine("Is this claim valid? True or False");
            string claimValid = Console.ReadLine();
            newCLaim.IsValid = bool.Parse(claimValid);

            _claimRepo.AddClaimToQueue(newCLaim);

        }
        private void ViewClaims()
        {
            Console.WriteLine("ClaimID\t  Claim Type\t Description\t    Amount\t  DateOfIncident\t  DateOfClaim\t IsValid ");
            foreach (Claim claim in _claim)
            {
                Console.WriteLine($"{claim.ClaimID}\t {claim.Type}\t\t  {claim.Description}\t\t {claim.Amount}\t\t {claim.DateOfAccident.ToShortDateString()}\t {claim.DateOfClaim.ToShortDateString()}\t {claim.IsValid}");
            }
            Console.ReadKey();
        }
        private void RemoveClaim()
        {
            Claim claim = _claimRepo.ViewNextClaim();
            Console.WriteLine("ClaimID\t  Claim Type\t Description\t    Amount\t  DateOfIncident\t  DateOfClaim\t IsValid ");
            
            Console.WriteLine($"{claim.ClaimID}\t {claim.Type}\t\t  {claim.Description}\t\t {claim.Amount}\t\t {claim.DateOfAccident.ToShortDateString()}\t {claim.DateOfClaim.ToShortDateString()}\t {claim.IsValid}");
            

            Console.WriteLine("Would you like to take care of the first claim? Enter y for yes or n for no");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                _claimRepo.RemoveClaim();
                Console.WriteLine("The claim has been removed");
            }
            else if (answer == "n")
            {
                Console.WriteLine("Press any key to return to main menu");

            }

            Console.ReadKey();
        }
    }
}
