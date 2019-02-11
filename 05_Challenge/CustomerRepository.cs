using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    public class CustomerRepository
    {
        private List<CustomerInfo> _customerInfo = new List<CustomerInfo>();
        public void AddCustomerToList(CustomerInfo customer)
        {
            _customerInfo.Add(customer);
        }

        public List<CustomerInfo> GetCustomerInfo()
        {
            _customerInfo.Sort((custOne, custTwo) => custOne.LastName.CompareTo(custTwo.LastName));

            return _customerInfo;
        }

        public void RemoveCustomer (string customerFirst, string customerLast)
        {
            foreach (CustomerInfo customer in _customerInfo)
            {
                if (customer.FirstName == customerFirst && customer.LastName == customerLast)
                {
                    _customerInfo.Remove(customer);
                    break;
                }
            }
        }

        public CustomerInfo GetCustomer(string customerFirst, string customerLast)
        {
            var customer = _customerInfo.Find(x => x.FirstName == customerFirst && x.LastName == customerLast);
            return customer;
        }

        public CustomerInfo UpdateCustomer(CustomerInfo customer, string newFirst, string newLast)
        {
            customer.FirstName = newFirst;
            customer.LastName = newLast;
            return customer;
        }
    }
}
