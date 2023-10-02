using BuilderAssignment.Builders;
using BuilderAssignment.Models;

namespace BuilderAssignment
{
    public class RamenChef
    {
        public RamenBowl PrepareRamen(IRamenBuilder builder)
        {
            //TODO#1: Call each builder step declared in RamenBuilder class
            builder.AddBroth();
            builder.AddNoodles();
            builder.AddToppings();
            builder.AddExtras();
            
            return builder.GetRamen(); //TODO#2: Finaly return build bowl of ramen
        }
    }
}
