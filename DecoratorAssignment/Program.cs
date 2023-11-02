namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there
    public abstract class Beverage
    {
        protected string description = "Unknown description";

        public string GetDescription() { return description;}

        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }

    public class Espresso : Beverage
    {
        protected double price = 1.99;
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return price;
        }
    }
    public class HouseBlend : Beverage
    {
        protected double price = .89;
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override double Cost()
        {
            return price;
        }
    }
    public class DarkRoast : Beverage
    {
        protected double price = .99;
        public DarkRoast()
        {
            description = "Dark roast";
        }

        public override double Cost()
        {
            return price;
        }
    }
    public class Decaf : Beverage
    {
        protected double price = 1.05;
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return price;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        protected double price = .20;
        private string desc = "Mocha";

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override double Cost()
        {
            return price + beverage.Cost();
        }
    }
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;
        protected double price = .1;
        private string desc = "Steamed milk";

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override double Cost()
        {
            return price + beverage.Cost();
        }
    }
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        protected double price = .15;
        private string desc = "Soy";

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override double Cost()
        {
            return price + beverage.Cost();
        }
    }
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        protected double price = .10;
        private string desc = "Whip";

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override double Cost()
        {
            return price + beverage.Cost();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}