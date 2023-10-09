using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteratorAndCompositeExercise.Program;

namespace IteratorAndCompositeExercise
{
    internal class DinerMenu
    {
        private int Max_Items = 6;
        int numberOfItems = 0;
        MenuItem[] MenuItems;

        public DinerMenu()
        {
            MenuItems = new MenuItem[Max_Items];

            AddItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat", true, 2.99);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= Max_Items)
            {
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                MenuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        public Iterator createIterator()
        {
            return new DinerMenuIterator(MenuItems);
        }

    }

    internal class DinerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else { return true; }
        }

        // Does not check whether next object exists. Must be used with hasNext().
        public object next()
        {
            MenuItem menuItem = items[position++];
            return menuItem;
        }
    }
}
