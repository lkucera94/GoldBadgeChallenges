using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Challenge
{
    class ProgramUI
    {
        private List<CustomerInfo> _customerInfo;
        private CustomerRepository _customerRepo;

        public ProgramUI()
        {
            _customerRepo = new CustomerRepository();
            _customerInfo = _customerRepo.GetCustomerInfo();
            CustomerInfo customer = new CustomerInfo();
            SeedList();
        }

        private void SeedList()
        {
            CustomerInfo customer = new CustomerInfo("Lauren", "Kucera", CustomerType.Potential);
            CustomerInfo customerTwo = new CustomerInfo("Lauren", "Smith", CustomerType.Past);
            CustomerInfo customerThree = new CustomerInfo("Rob", "Kucera", CustomerType.Potential);
            CustomerInfo customerFour = new CustomerInfo("Lauren", "Kucera", CustomerType.Current);
            CustomerInfo customerx = new CustomerInfo("Lauren", "Smithy", CustomerType.Potential);
            CustomerInfo customery = new CustomerInfo("Sean", "Kucera", CustomerType.Past);
            CustomerInfo customere = new CustomerInfo("Lauren", "Blah", CustomerType.Potential);
            CustomerInfo customerf = new CustomerInfo("Lauren", "Kucera", CustomerType.Current);

            _customerRepo.AddCustomerToList(customer);
            _customerRepo.AddCustomerToList(customerTwo);
            _customerRepo.AddCustomerToList(customerThree);
            _customerRepo.AddCustomerToList(customerFour);
            _customerRepo.AddCustomerToList(customerx);
            _customerRepo.AddCustomerToList(customery);
            _customerRepo.AddCustomerToList(customerf);
            _customerRepo.AddCustomerToList(customere);

        }

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add a customer\n" +
                    "2. Update customer information\n" +
                    "3. Remove a customer\n" +
                    "4. Display customer list with email message\n" +
                    "5. Exit");


                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);
                switch (input)
                {
                    case 1:
                        AddCustomer();
                        break;

                    case 2:
                        UpdateCustomer();
                        break;

                    case 3:
                        RemoveCustomer();
                        break;

                    case 4:
                        ViewCustomerList();
                        break;

                    case 5:
                        running = false;
                        break;
                }
            }
        }
        private void AddCustomer()
        {
            CustomerInfo newCustomer = new CustomerInfo();

            Console.WriteLine("What is the customer's first name?");
            newCustomer.FirstName = Console.ReadLine();

            Console.WriteLine("What is the customer's last name?");
            newCustomer.LastName = Console.ReadLine();

            Console.WriteLine("What type of customer are they?\n" +
                "1. Current\n" +
                "2. Potential\n" +
                "3. Past");
            string inputAsString = Console.ReadLine().ToLower();
            switch (inputAsString)
            {
                case "current":
                case "1":
                    newCustomer.TypeOfCustomer = CustomerType.Current;
                    break;
                case "potential":
                case "2":
                    newCustomer.TypeOfCustomer = CustomerType.Potential;
                    break;
                case "past":
                case "3":
                    newCustomer.TypeOfCustomer = CustomerType.Past;
                    break;
            }
            _customerRepo.AddCustomerToList(newCustomer);
        }
        private void RemoveCustomer()
        {
            Console.WriteLine("What is the customer's first name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is the customer's last name?");
            string lastName = Console.ReadLine();

            _customerRepo.RemoveCustomer(firstName, lastName);
            
        }

        private void ViewCustomerList()
        {
            List<CustomerInfo> _customerInfo = _customerRepo.GetCustomerInfo();
            Console.WriteLine("Last, First\t   Type\t        Email");
            foreach (CustomerInfo customer in _customerInfo)
            {
                if (customer.TypeOfCustomer == CustomerType.Current)
                {
                    Console.WriteLine($"{customer.LastName}, {customer.FirstName}   {customer.TypeOfCustomer}    Thank you for your work with us. We appreciate your loyalty!");
                }
                else if (customer.TypeOfCustomer == CustomerType.Potential)
                {
                    Console.WriteLine($"{customer.LastName}, {customer.FirstName}   {customer.TypeOfCustomer}     We offer the lowest rates on insurance! Contact us to find out more.");
                }
                else if (customer.TypeOfCustomer == CustomerType.Past)
                {
                    Console.WriteLine($"{customer.LastName}, {customer.FirstName}   {customer.TypeOfCustomer}      It's been a long time since we have heard from you. We'd like to have you back.");
                }


            }
            Console.ReadKey();
        }
        private void UpdateCustomer()
        {
            ViewCustomerList();
            Console.WriteLine("What is the first name you want to update?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is the last name you want to update?");
            string lastName = Console.ReadLine();

            CustomerInfo updatedCustomer = _customerRepo.GetCustomer(firstName, lastName);

            Console.WriteLine("What is the new first name?");
            updatedCustomer.FirstName = Console.ReadLine();

            Console.WriteLine("What is the new last name?");
            updatedCustomer.LastName = Console.ReadLine();

            Console.WriteLine("What is the customer type?\n" +
                "1. Current\n" +
                "2. Potential\n" +
                "3. Past");
            string customerType = Console.ReadLine().ToLower();
            switch (customerType)
            {
                case "current":
                case "1":
                    updatedCustomer.TypeOfCustomer = CustomerType.Current;
                    break;
                case "potential":
                case "2":
                    updatedCustomer.TypeOfCustomer = CustomerType.Potential;
                    break;
                case "past":
                case "3":
                    updatedCustomer.TypeOfCustomer = CustomerType.Past;
                    break;
            }
        }
           
    }
}
