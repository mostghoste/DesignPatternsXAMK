using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment.Models
{
    /// <summary>
    /// This class represents the final bowl of ramen
    /// It should have attributes like broth, type of noodle, toppings and extras
    /// </summary>
    public class RamenBowl
    {
        //TODO#1: Add attributes for each enum in IngredientEnums.cs file

        public BrothType Broth { get; set; }
        public NoodleType Noodle { get; set; }
        public List<Topping> Topping { get; set; }

        // It would probably make sense to convert the Extra to a list as well, but as the assignment
        // does not require any ramen with multiple extras, this will be fine for now.
        public Extra? Extra { get; set; }

        public RamenBowl() { Topping = new List<Topping>();  }

        //TODO#2: Return description of finished bowl of ramen
        public string FinishedBowlOfRamen()
        {
            // Turn topping list into a single string.
            string toppings;
            if (Topping.Count > 0)
            {
                toppings = Topping[0].ToString();
                for (int i = 1; i < Topping.Count; i++)
                {
                    toppings += "; " + Topping[i].ToString();
                }
            }
            else
            {
                toppings = "None";
            }

            // Check if ramen has extras and format the output accordingly
            string extra = Extra != null ? Extra.ToString() : "None";

            // Format and return the final ramen ingredient string
            string ramen = String.Format(" Broth: {0}\n Noodle: {1}\n Topping: {2}\n Extra: {3}",
                Broth.ToString(),
                Noodle.ToString(),
                toppings,
                extra
                );
            return ramen;
        }
    }
}
