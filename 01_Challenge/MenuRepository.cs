using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuRepository
    //create item, delete item, list items on menu
    {
        private List<Menu> _menu = new List<Menu>();
        public void AddMenuItem(Menu item)
        {
            _menu.Add(item);
        }

        public List<Menu> GetMenuItems()
        {
            return _menu;
        }

        public void RemoveMenuItem(int item)
        {
            foreach (Menu menu in _menu)
            {
                if (menu.MealNumber == item)
                {
                    _menu.Remove(menu);
                    break;
                }
            }
        }
    }
}
