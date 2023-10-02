using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    internal class VeganRamenBuilder : IRamenBuilder
    {
        /// - VeganRamenBuilder
        ///     Recepie: 
        ///     - Broth: Vegan
        ///     - Noodles: Soba
        ///     - Toppings: Bambo Shoots & Seaweed
        ///     - Extras: no extras
        private RamenBowl ramen = new RamenBowl();

        public void AddBroth()
        {
            ramen.Broth = BrothType.Vegan;
        }
        public void AddNoodles()
        {
            ramen.Noodle = NoodleType.Soba;
        }
        public void AddToppings()
        {
            ramen.Topping.Add(Topping.BambooShoots);
            ramen.Topping.Add(Topping.Seaweed);
        }

        public void AddExtras()
        {
            ramen.Extra = null;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
