﻿using System.Runtime.CompilerServices;

namespace DesignPatterns
{
    // Class for Printer
    // TODO#1: Convert to use Singleton pattern
    public class Printer
    {
        private static Printer? _instance;

        private Printer() { }

        /// <summary>
        /// Singleton logic:
        /// If instance is null, creates a new object and saves it.
        /// If object already exists, returns the object.
        /// </summary>
        /// <returns>Printer instance</returns>
        public static Printer getInstance()
        {
            if (_instance == null)
            {
                _instance = new Printer();
            }
            return _instance;
        }

        public void Print(string message)
        {
            // Output: print out the string message 
            Console.WriteLine(message);
        }
    }

    // Class template for Exam classes
    // TODO#2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.
    public class MathExam
    {
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
        }
    }

    // TODO#5: Add new ScienceExam class

    // TODO#6: Add another ProgrammingExam class

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // TODO#7: Initialize Printer that uses Singleton pattern
            // TODO#8: Test that the created Printer works, by calling the Print method

            // TODO#9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object

            // TODO#10: Use Abstract Factory to create different types of exams.
        }
    }

}