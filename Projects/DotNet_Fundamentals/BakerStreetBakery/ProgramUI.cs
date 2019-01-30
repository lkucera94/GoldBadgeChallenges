using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakerStreetBakery
{
    class ProgramUI
    {
        private Product _product;
        private ProductRepository _productRepo;

        public ProgramUI()
        {
            _product = new Product();
            _productRepo = new ProductRepository();
        }

        public void Run()
        {
            bool running = true;
            while (running)
            {

                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. New Order\n" +
                    "2. View Order\n" +
                    "3. Remove Order\n" +
                    "4. Exit");

                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        NewOrder();
                        break;
                    case 2:
                        ViewOrder();
                        break;
                    case 3:
                        RemoveOrder();
                        break;
                    case 4:
                        running = false;
                        break;

                }
            }
        }
        private void NewOrder()
        {
            Console.WriteLine("What is the customer's name?");
            _product.CustomerName = Console.ReadLine();

            Console.WriteLine("What type of product is being ordered?\n" +
                "1. Bread\n" +
                "2. Cake\n" +
                "3. Pastry\n" +
                "4. Pie\n");
            string productAsString = Console.ReadLine().ToLower();
            switch (productAsString)
            {
                case "1":
                    _product.BakeItem = BakeType.Bread;
                    break;
                case "2":
                    _product.BakeItem = BakeType.Cake;
                    break;
                case "3":
                    _product.BakeItem = BakeType.Pastry;
                    break;
                case "4":
                    _product.BakeItem = BakeType.Pie;
                    break;
            }

            Console.WriteLine("What is the name of the product?");
            _product.ProductName = Console.ReadLine();

            Console.WriteLine("What is the order's batch size?");
            string batchSizeAsString = Console.ReadLine();
            _product.OrderBatchSize = int.Parse(batchSizeAsString);
        }
        private void ViewOrder()
        {
            List<Product> orderList = _productRepo.GetProductList();
            Console.WriteLine($"Hello {_product.CustomerName}. You ordered {_product.OrderBatchSize} {_product.ProductName}(s)");

            decimal cost = 0;
            foreach (Product product in orderList)
            {
                cost = _productRepo.CalculateCost(product.BakeItem);
                
            Console.WriteLine($"The order cost is ${cost}");
            Console.ReadKey();
            }

        }
        private void RemoveOrder()
        {
            
        }
    }
}
