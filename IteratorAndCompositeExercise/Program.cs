using System.Collections;

namespace IteratorAndCompositeExercise
{
    // For this exercise try complete the Iterator and Composite example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 9 the Iterator and Composite Patterns (starts at page 315)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    internal class Program
    {
        static void Main(string[] args)
        {
            DinerMenu dinerMenu = new DinerMenu();
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();

            Waitress waitress = new Waitress(dinerMenu, pancakeHouseMenu);

            Console.WriteLine("Welcome to the diner!");
            waitress.printMenu();
        }
    }
}