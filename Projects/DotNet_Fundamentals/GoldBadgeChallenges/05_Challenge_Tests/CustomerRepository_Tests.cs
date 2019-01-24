using System;
using _05_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _05_Challenge_Tests
{
    [TestClass]
    public class CustomerRepository_Tests
    {
        [TestMethod]
        public void CustomerRepository_AddCustomer_ShouldBeCorrectCount()

        {
            CustomerRepository _customerRepo = new CustomerRepository();
            CustomerInfo customerOne = new CustomerInfo();
            CustomerInfo customerTwo = new CustomerInfo();
            CustomerInfo customerThree = new CustomerInfo();

            customerOne.LastName = "Allen";
            customerTwo.LastName = "Smith";
            customerThree.LastName = "Baker";

            _customerRepo.AddCustomerToList(customerOne);
            _customerRepo.AddCustomerToList(customerTwo);
            _customerRepo.AddCustomerToList(customerThree);

            int actual = _customerRepo.GetCustomerInfo().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CustomerRepository_RemoveCustomer_ShouldBeCorrectCount()
        {
            CustomerRepository _customerRepo = new CustomerRepository();
            CustomerInfo customerOne = new CustomerInfo();
            CustomerInfo customerTwo = new CustomerInfo();
            CustomerInfo customerThree = new CustomerInfo();

            _customerRepo.AddCustomerToList(customerOne);
            _customerRepo.AddCustomerToList(customerTwo);
            _customerRepo.AddCustomerToList(customerThree);

            customerOne.FirstName = "firstname";
            customerOne.LastName = "lastname";

            customerTwo.FirstName = "firsty";
            customerTwo.LastName = "lasty";

            customerThree.FirstName = "freshy";
            customerThree.LastName = "softy";


            _customerRepo.RemoveCustomer("firstname", "lastname");
            int actual = _customerRepo.GetCustomerInfo().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CustomerRepository_GetCustomer_ShouldBeCorrect()
        {
            CustomerRepository _customerRepo = new CustomerRepository();
            CustomerInfo customerOne = new CustomerInfo();
            CustomerInfo customerTwo = new CustomerInfo();
            CustomerInfo customerThree = new CustomerInfo();

            _customerRepo.AddCustomerToList(customerOne);
            _customerRepo.AddCustomerToList(customerTwo);
            _customerRepo.AddCustomerToList(customerThree);

            customerOne.FirstName = "firstname";
            customerOne.LastName = "lastname";

            customerTwo.FirstName = "firsty";
            customerTwo.LastName = "lasty";

            customerThree.FirstName = "freshy";
            customerThree.LastName = "softy";

            CustomerInfo customerFour = _customerRepo.GetCustomer("firstname", "lastname");

            Assert.AreEqual(customerFour, customerOne);

            


        }
    }
}
