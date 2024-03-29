﻿using System.Runtime.CompilerServices;

namespace DesignPatterns
{
    // Class for Printer
    // #1: Convert to use Singleton pattern
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
    // #2: Convert to use Abstract Factory pattern
    // Create an Exam interface and an Abstract Factory to manage the creation of different exam types.
    public interface Exam
    {
        public Printer printer {  get; }
        public void Conduct();
        public void Evaluate();
        public void PublishResults();
    }

    public abstract class ExamFactory
    {
        public abstract Exam CreateExam();
    }

    public class MathExamFactory : ExamFactory
    {
        public override Exam CreateExam()
        {
            return new MathExam();
        }
    }
    public class ScienceExamFactory : ExamFactory
    {
        public override Exam CreateExam()
        {
            return new ScienceExam();
        }
    }
    public class ProgrammingExamFactory : ExamFactory
    {
        public override Exam CreateExam()
        {
            return new ProgrammingExam();
        }
    }

    public class MathExam : Exam
    {
        public Printer printer { get; }
        public MathExam()
        {
            printer = Printer.getInstance();
        }
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            printer.Print("Conducting Math Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            printer.Print("Evaluating Math Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            printer.Print("Publishing Math Exam Results");
        }
    }

    // #5: Add new ScienceExam class
    public class ScienceExam : Exam
    {
        public Printer printer { get; }
        public ScienceExam()
        {
            printer = Printer.getInstance();
        }
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            printer.Print("Conducting Science Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            printer.Print("Evaluating Science Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            printer.Print("Publishing Science Exam Results");
        }
    }
    // #6: Add another ProgrammingExam class
    public class ProgrammingExam : Exam
    {
        public Printer printer { get; }
        public ProgrammingExam()
        {
            printer = Printer.getInstance();
        }
        public void Conduct()
        {
            // Output: "Conducting Math Exam", should use Printer class to print the message
            printer.Print("Conducting Programming Exam");
        }

        public void Evaluate()
        {
            // Output: "Evaluating Math Exam", should use Printer class to print the message
            printer.Print("Evaluating Programming Exam");
        }

        public void PublishResults()
        {
            // Output: "Publishing Math Exam Results", should use Printer class to print the message
            printer.Print("Publishing Programming Exam Results");
        }
    }
    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // #7: Initialize Printer that uses Singleton pattern
            Printer printer = Printer.getInstance();
            // #8: Test that the created Printer works, by calling the Print method
            printer.Print("Test for Printer singleton.");

            // #9: Ensure that only one Printer instance is used throughout the application.
            //         Try to create new Printer object
            
            // The below line does not let us create a new Printer because the constructor is private.
            // Printer printer2 = new Printer();
            Printer printer2 = Printer.getInstance();
            printer2.Print("Test 2");
            //We get the hash code for both printer objects. Since they refer to the same object, their hash code should be the same.
            printer2.Print("Hash code comparision: " + printer.GetHashCode().ToString() + " - " + printer2.GetHashCode().ToString());

            // #10: Use Abstract Factory to create different types of exams.
            CreateAndConductExam(new MathExamFactory());
            CreateAndConductExam(new ScienceExamFactory());
            CreateAndConductExam(new ProgrammingExamFactory());
        }

        static void CreateAndConductExam(ExamFactory factory)
        {
            Exam exam = factory.CreateExam();
            exam.Conduct();
            exam.Evaluate();
            exam.PublishResults();
        }
    }

}