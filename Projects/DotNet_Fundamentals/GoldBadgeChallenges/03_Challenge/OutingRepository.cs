using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class OutingRepository
    {
        private List<Outing> _outing = new List<Outing>();
        public void AddOutingToList(Outing outing)
        {
            _outing.Add(outing);
        }

        public List<Outing> GetOutings()
        {
            return _outing;
        }

        public decimal CalculateCostOfEventType(EventType type)
        {
            decimal eventCost = 0;
            foreach (Outing eventType in _outing)
            {

                if (eventType.TypeOfEvent == type)
                
                    eventCost += eventType.TotalCost;
                
            }
            return eventCost;
        }

        public decimal CalculateCostOfAllEvents()
        {
            decimal eventCosts = 0;
            foreach(Outing outing in _outing)
            {
                eventCosts += outing.TotalCost;
            }
            return eventCosts;
        }
    }
}
