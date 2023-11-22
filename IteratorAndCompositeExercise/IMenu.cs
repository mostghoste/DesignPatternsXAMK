using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndCompositeExercise
{
    internal interface IMenu
    {
        Iterator CreateIterator();
        void AddItem(string name, string description, bool vegetarian, double price);
    }
}
