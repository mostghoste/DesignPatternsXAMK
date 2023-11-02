﻿namespace DecoratorAssignment
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

        public string getDescription() { return description;}

        public abstract double cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string getDescription();
    }

    public class Espresso : Beverage
    {
        protected double price = 1.99;
        public Espresso()
        {
            description = "Espresso";
        }

        public override double cost()
        {
            return price;
        }
    }
    public class HouseBlend : Beverage
    {
        protected double price = 1.50;
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override double cost()
        {
            return price;
        }
    }
    public class DarkRoast : Beverage
    {
        protected double price = 2.00;
        public DarkRoast()
        {
            description = "Dark roast";
        }

        public override double cost()
        {
            return price;
        }
    }
    public class Decaf : Beverage
    {
        protected double price = 1.00;
        public Decaf()
        {
            description = "Decaf";
        }

        public override double cost()
        {
            return price;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}