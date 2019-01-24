using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    class ProgramUI
    {
        private Outing _outing;
        private OutingRepository _outingRepo;

        public ProgramUI()
        {
            _outingRepo = new OutingRepository();
            _outing = new Outing();

        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add an outing\n" +
                    "2. View outing cost by type\n" +
                    "3. View total outing costs\n" +
                    "4. View all outings\n" +
                    "5. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        AddOuting();
                        break;
                    case 2:
                        ViewTypeCost();
                        break;
                    case 3:
                        ViewTotalCost();
                        break;
                    case 4:
                        ViewOutings();
                        break;
                    case 5:
                        running = false;
                        break;
                }
            }
        }
        private void AddOuting()
        {
            Outing newOuting = new Outing();

            Console.WriteLine("What is the event type?\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Concert\n" +
                "4. Amusement Park");
            string typeAsString = Console.ReadLine().ToLower();
            switch (typeAsString)
            {
                case "golf":
                case "1":
                    newOuting.TypeOfEvent = EventType.Golf;
                    break;
                case "bowling":
                case "2":
                    newOuting.TypeOfEvent = EventType.Bowling;
                    break;
                case "concert":
                case "3":
                    newOuting.TypeOfEvent = EventType.Concert;
                    break;
                case "amusement park":
                case "4":
                    newOuting.TypeOfEvent = EventType.AmusementPark;
                    break;
            }
            Console.WriteLine("How many people are attending?");
            string attendanceAsString = Console.ReadLine();
            newOuting.NumberOfPeople = int.Parse(attendanceAsString);

            Console.WriteLine("When is the outing?\n" +
                "Use the format mm/dd/yyyy (time)pm/am");
            string dateOfEvent = Console.ReadLine();
            newOuting.DateOfEvent = DateTime.Parse(dateOfEvent);

            Console.WriteLine("What is the cost per person?");
            string costPerPerson = Console.ReadLine();
            newOuting.CostPerPerson = decimal.Parse(costPerPerson);

            Console.WriteLine("What is the total cost of the outing?");
            string totalOutingCost = Console.ReadLine();
            newOuting.TotalCost = decimal.Parse(totalOutingCost);

            _outingRepo.AddOutingToList(newOuting);

        }
        private void ViewOutings()
        {
            List<Outing> outings = _outingRepo.GetOutings();
            foreach (Outing outing in outings)
            {
                Console.WriteLine($"The {outing.TypeOfEvent} on {outing.DateOfEvent} will have {outing.NumberOfPeople} people.\n" +
                    $"The cost per person will be ${outing.CostPerPerson} and total cost will be ${outing.TotalCost}");
            }
            Console.ReadKey();
        }
        private void ViewTypeCost()
        {
            Console.WriteLine("What is the event type?\n" +
                   "1. Golf\n" +
                   "2. Bowling\n" +
                   "3. Concert\n" +
                   "4. Amusement Park");
            string typeAsString = Console.ReadLine().ToLower();
            EventType type = EventType.AmusementPark;
            switch (typeAsString)
            {
                case "golf":
                case "1":
                    type = EventType.Golf;
                    break;
                case "bowling":
                case "2":
                    type = EventType.Bowling;
                    break;
                case "concert":
                case "3":
                    type = EventType.Concert;
                    break;
                case "amusement park":
                case "4":
                    type = EventType.AmusementPark;
                    break;
            }
            decimal cost = _outingRepo.CalculateCostOfEventType(type);
            Console.WriteLine($"The cost is ${cost}");



            Console.ReadKey();
        }

        private void ViewTotalCost()
        {
            decimal totalCost = 0;
            decimal golf = _outingRepo.CalculateCostOfEventType(EventType.Golf);
            decimal bowling = _outingRepo.CalculateCostOfEventType(EventType.Bowling);
            decimal concert = _outingRepo.CalculateCostOfEventType(EventType.Concert);
            decimal amusementPark = _outingRepo.CalculateCostOfEventType(EventType.AmusementPark);

            totalCost = golf + bowling + concert + amusementPark;

            Console.WriteLine($"The total cost of events is ${totalCost}");
            Console.ReadKey();
        }


    }

}
