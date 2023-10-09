using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositeExercise
{
    internal class Waitress
    {
        DinerMenu dinerMenu;
        PancakeHouseMenu pancakeHouseMenu;
        
        public Waitress(DinerMenu dinerMenu, PancakeHouseMenu pancakeHouseMenu)
        {
            this.dinerMenu = dinerMenu;
            this.pancakeHouseMenu = pancakeHouseMenu;
        }

        public void printMenu()
        {
            Iterator dinerIterator = dinerMenu.createIterator();
            Iterator pancakeIterator = pancakeHouseMenu.createIterator();

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
