using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IteratorAndCompositeExercise.Program;

namespace IteratorAndCompositeExercise
{
    internal class DinerMenu : IMenu
    {
        private int Max_Items = 6;
        int numberOfItems = 0;
        MenuItem[] MenuItems;

        public DinerMenu()
        {
            MenuItems = new MenuItem[Max_Items];

            AddItem("Vegetarian BLT", "(Fakin´) Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day","Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog","A hot dog, with saurkraut, relish, onions, topped with cheese",false, 3.05);
            AddItem("Steamed Veggies and Brown Rice","Steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta","Spaghetti with Marinara Sauce, and a slice of sourdough bread",true, 3.89);
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

        public Iterator CreateIterator()
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
