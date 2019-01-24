using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{   public enum CustomerType { Current, Potential, Past}
    public class CustomerInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CustomerType TypeOfCustomer { get; set; }
        

        public CustomerInfo() { }

        public CustomerInfo(string firstName, string lastName, CustomerType typeOfCustomer)
        {
            FirstName = firstName;
            LastName = lastName;
            TypeOfCustomer = typeOfCustomer;
            
        }
        

    }
}
