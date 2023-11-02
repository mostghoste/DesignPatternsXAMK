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

        public abstract decimal Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }

    public class Espresso : Beverage
    {
        protected decimal price = 1.99M;
        public Espresso()
        {
            description = "Espresso";
        }

        public override decimal Cost()
        {
            return price;
        }
    }
    public class HouseBlend : Beverage
    {
        protected decimal price = .89M;
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override decimal Cost()
        {
            return price;
        }
    }
    public class DarkRoast : Beverage
    {
        protected decimal price = .99M;
        public DarkRoast()
        {
            description = "Dark roast";
        }

        public override decimal Cost()
        {
            return price;
        }
    }
    public class Decaf : Beverage
    {
        protected decimal price = 1.05M;
        public Decaf()
        {
            description = "Decaf";
        }

        public override decimal Cost()
        {
            return price;
        }
    }

    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        protected decimal price = .20M;
        private string desc = "Mocha";

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override decimal Cost()
        {
            return price + beverage.Cost();
        }
    }
    public class SteamedMilk : CondimentDecorator
    {
        Beverage beverage;
        protected decimal price = .1M;
        private string desc = "Steamed milk";

        public SteamedMilk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override decimal Cost()
        {
            return price + beverage.Cost();
        }
    }
    public class Soy : CondimentDecorator
    {
        Beverage beverage;
        protected decimal price = .15M;
        private string desc = "Soy";

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override decimal Cost()
        {
            return price + beverage.Cost();
        }
    }
    public class Whip : CondimentDecorator
    {
        Beverage beverage;
        protected decimal price = .10M;
        private string desc = "Whip";

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", " + desc;
        }
        public override decimal Cost()
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