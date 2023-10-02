using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    internal class MisoRamenBuilder : IRamenBuilder
    {
        /// - MisoRamenBuilder
        ///     Recepie: 
        ///     - Broth: Miso
        ///     - Noodles: Udon
        ///     - Toppings: Green Onions
        ///     - Extras: Corn
        private RamenBowl ramen = new RamenBowl();

        public void AddBroth()
        {
            ramen.Broth = BrothType.Miso;
        }
        public void AddNoodles()
        {
            ramen.Noodle = NoodleType.Udon;
        }
        public void AddToppings()
        {
            ramen.Topping.Add(Topping.GreenOnions);
        }

        public void AddExtras()
        {
            ramen.Extra = Extra.Corn;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
