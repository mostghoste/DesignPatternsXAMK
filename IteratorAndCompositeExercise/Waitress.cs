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
        
        public Waitress(DinerMenu dinerMenu)
        {
            this.dinerMenu = dinerMenu;
        }

        public void printMenu()
        {
            Iterator dinerIterator = dinerMenu.createIterator();
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
