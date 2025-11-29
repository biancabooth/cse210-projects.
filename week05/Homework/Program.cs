using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Assignment studentInfo1 = new Assignment ("Samuel Bennet","Multiplication");
        Console.WriteLine(studentInfo1.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment1 = new MathAssignment ("Roberto Rodriguez","Fractions","Section 7.3","Problem 8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters","European History","The Cause of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());
    }
}