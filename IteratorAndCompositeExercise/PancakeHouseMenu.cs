using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteratorAndCompositeExercise.Program;

namespace IteratorAndCompositeExercise
{
    internal class PancakeHouseMenu
    {
        public ArrayList MenuItems { get; set; }

        public PancakeHouseMenu()
        {
            MenuItems = new ArrayList();

            AddItem("K&B´s Pancake Breakfast", "Pancakes with scrambled eggs, and toast", false, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            MenuItems.Add(menuItem);
        }

        public Iterator createIterator()
        {
            return new PancakeHouseIterator(MenuItems);
        }
    }

    internal class PancakeHouseIterator : Iterator
    {
        ArrayList MenuItems;
        int position = 0;
        public PancakeHouseIterator(ArrayList menuItems)
        {
            MenuItems = menuItems;
        }

        public bool hasNext()
        {
            if (position >= MenuItems.Count || MenuItems[position] == null)
            {
                return false;
            }
            return true;
        }

        public object next()
        {
            return MenuItems[position++];
        }
    }
}
