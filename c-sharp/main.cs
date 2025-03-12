using System;

namespace BasicCSharpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calling our main function with different values
            GradeStudent("Alice", 95);
            GradeStudent("Bob", 85);
            GradeStudent("Charlie", 75);
            GradeStudent("David", 65);
            GradeStudent("Eve", 55);
            
            // Wait for user input before closing
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
        
        // Main function that takes parameters and uses if conditions
        static void GradeStudent(string name, int score)
        {
            string grade;
            
            // If-else ladder to determine the grade
            if (score >= 90)
            {
                grade = "A";
            }
            else if (score >= 80)
            {
                grade = "B";
            }
            else if (score >= 70)
            {
                grade = "C";
            }
            else if (score >= 60)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }
            
            // Call helper function to format and display the result
            DisplayResult(name, score, grade);
            
            // Using helper function to check if student passed
            bool passed = HasPassed(grade);
            Console.WriteLine($"{name} {(passed ? "passed" : "failed")} the course.");
        }
        
        // Helper function to display formatted results
        static void DisplayResult(string name, int score, string grade)
        {
            Console.WriteLine($"Student: {name}, Score: {score}, Grade: {grade}");
        }
        
        // Helper function that returns a boolean value
        static bool HasPassed(string grade)
        {
            // Return true if grade is not F
            return grade != "F";
        }
    }
}
