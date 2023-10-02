using BuilderAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Builders
{
    internal class SpicyRamenBuilder : IRamenBuilder
    {
        /// - SpicyRamenBuilder
        ///     Recepie: 
        ///     - Broth: SpicyTonkotsu
        ///     - Noodles: Thin
        ///     - Toppings: Gashu Pork & Green Onions
        ///     - Extras: Extra Spice
        private RamenBowl ramen = new RamenBowl();

        public void AddBroth()
        {
            ramen.Broth = BrothType.SpicyTonkotsu;
        }
        public void AddNoodles()
        {
            ramen.Noodle = NoodleType.Thin;
        }
        public void AddToppings()
        {
            ramen.Topping.Add(Topping.ChashuPork);
            ramen.Topping.Add(Topping.GreenOnions);
        }

        public void AddExtras()
        {
            ramen.Extra = Extra.ExtraSpice;
        }

        public RamenBowl GetRamen()
        {
            return ramen;
        }
    }
}
