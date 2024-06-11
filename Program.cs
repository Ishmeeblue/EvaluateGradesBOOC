using System;
namespace Evaluate_Grades_BOOC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter how many grades you want to input: ");
            int numberOfGrades = Convert.ToInt16(Console.ReadLine());
            double[] grades = new double[numberOfGrades];
            Collection(numberOfGrades, grades);
            Console.WriteLine("END OF USER INPUT");

            Console.WriteLine("PROCESSING GRADES....");

            Average(numberOfGrades, grades);
        }

        public static void Collection(int numberOfGrades, double[] grades)
        {

            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write("Input grade: ");
                double grade = Convert.ToDouble(Console.ReadLine());

                if (grade > 0 && grade < 100)
                {
                    grades[counter] = grade;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
        }

        public static void Average(int numberOfGrades, double[] grades)
        {
            double sum = 0;


            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                sum += grades[counter];
            }

            double average = sum / numberOfGrades;

            Console.WriteLine("The average grade is " + average);

            if (average <= 50)
            {
                Console.WriteLine("FAILED");
            }
            else if (average > 50 && average <= 70)
            {
                Console.WriteLine("FAIR");
            }
            else if (average > 70 && average <= 80)
            {
                Console.WriteLine("GOOD");
            }
            else if (average > 80 && average <= 90)
            {
                Console.WriteLine("VERY GOOD");
            }
            else if (average > 90 && average <= 100)
            {
                Console.WriteLine("EXCELLENT");
            }

            Console.WriteLine("here are the grades given by your professor:");

            for (int counter = 0; counter < numberOfGrades; counter++)
            {
                Console.Write(grades[counter] + "-");
            }
        }
    }
}
