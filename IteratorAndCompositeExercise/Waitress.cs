using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositeExercise
{
    internal class Waitress
    {
        // I suppose it would be good to store these in a List or something
        // But since we only have two menus now, it's fine
        IMenu dinerMenu;
        IMenu pancakeHouseMenu;
        
        public Waitress(IMenu dinerMenu, IMenu pancakeHouseMenu)
        {
            this.dinerMenu = dinerMenu;
            this.pancakeHouseMenu = pancakeHouseMenu;
        }

        public void printMenu()
        {
            Iterator dinerIterator = dinerMenu.CreateIterator();
            Iterator pancakeIterator = pancakeHouseMenu.CreateIterator();

            Console.WriteLine("--- Breakfast menu ---");
            printMenu(pancakeIterator);
            Console.WriteLine("--- Diner menu ---");
            printMenu(dinerIterator);
        }

        private void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                MenuItem menuItem = (MenuItem) iterator.next();
                Console.WriteLine(menuItem.ToString());
            }
        }
    }
}
