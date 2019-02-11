using System;
using System.Collections.Generic;

namespace _01_Challenge
{
    class ProgramUI
    {
        private List<Menu> _menu;
        private MenuRepository _menuRepo;

        public ProgramUI()
        {
            _menuRepo = new MenuRepository();
            _menu = _menuRepo.GetMenuItems();
            Menu menu = new Menu();

        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("What would you like to do?\n" +
                    "1. Add a menu item\n" +
                    "2. Remove a menu item\n" +
                    "3. View the menu\n" +
                    "4. Exit");
                string inputAsString = Console.ReadLine();
                int input = int.Parse(inputAsString);

                switch (input)
                {
                    case 1:
                        AddAMenuItem();
                        break;
                    case 2:
                        RemoveAMenuItem();
                        break;
                    case 3:
                        ViewTheMenu();
                        break;
                    case 4:
                        running = false;
                        break;

                }
            }

        }
            private void AddAMenuItem()

            {
                Menu newMenu = new Menu();

                Console.WriteLine("What is the meal's name?");
                newMenu.MealName = Console.ReadLine();

                Console.WriteLine("What is the meal number?");
                string numberAsString = Console.ReadLine();
                newMenu.MealNumber = int.Parse(numberAsString);

                Console.WriteLine("What is the meal description?");
                newMenu.MealDescription = Console.ReadLine();

                Console.WriteLine("What are the ingredients?");
                newMenu.MealIngredients = Console.ReadLine();

                Console.WriteLine("What is the meal price?");
                string priceAsString = Console.ReadLine();
                newMenu.MealPrice = decimal.Parse(priceAsString);

                _menuRepo.AddMenuItem(newMenu);


            }
        private void RemoveAMenuItem()
        {
            Console.WriteLine("What is the meal number you would like to remove?");
            string numberAsString = Console.ReadLine();
            int mealNumber = int.Parse(numberAsString);

            _menuRepo.RemoveMenuItem(mealNumber);

        }
        private void ViewTheMenu()
        {
            foreach (Menu item in _menu)
            {
                Console.WriteLine($"#{item.MealNumber} is a {item.MealName}. It is {item.MealDescription} made with {item.MealIngredients}. It costs {item.MealPrice}");
            }
            Console.ReadKey();
        }

    }  
}
