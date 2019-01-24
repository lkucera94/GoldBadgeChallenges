using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public enum EventType {Golf, Bowling, AmusementPark, Concert}
    public class Outing
    {
        public int NumberOfPeople { get; set; }
        public DateTime DateOfEvent { get; set; }
        public decimal CostPerPerson { get; set; }
        public decimal TotalCost { get; set; }
        public EventType TypeOfEvent { get; set; }

        public Outing() {}

        public Outing(int numberOfPeople, DateTime dateOfEvent, decimal costPerPerson, decimal totalCost, EventType typeOfEvent)
        {
            NumberOfPeople = numberOfPeople;
            DateOfEvent = dateOfEvent;
            CostPerPerson = costPerPerson;
            TotalCost = totalCost;
            TypeOfEvent = typeOfEvent;
        }

        
    }
}
