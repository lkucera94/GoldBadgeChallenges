using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class MenuRepository_Tests
    {
        [TestMethod]
        public void MenuRepository_AddMenuItem_ShouldBeCorrectCount()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu menu = new Menu();
            Menu menuTwo = new Menu();
            Menu menuThree = new Menu();

            _menuRepo.AddMenuItem(menu);
            _menuRepo.AddMenuItem(menuTwo);
            _menuRepo.AddMenuItem(menuThree);

            int actual = _menuRepo.GetMenuItems().Count;
            int expected = 3;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuRepository_RemoveMenuItem_ShouldBeCorrectCount()
        {
            MenuRepository _menuRepo = new MenuRepository();
            Menu menu = new Menu();
            Menu menuTwo = new Menu();
            Menu menuThree = new Menu();

            _menuRepo.AddMenuItem(menu);
            _menuRepo.AddMenuItem(menuTwo);
            _menuRepo.AddMenuItem(menuThree);

            menu.MealNumber = 1;
            menuTwo.MealNumber = 3;
            menuThree.MealNumber = 5;

            _menuRepo.RemoveMenuItem(5);

            int actual = _menuRepo.GetMenuItems().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
