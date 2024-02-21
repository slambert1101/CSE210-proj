using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment = new MathAssignment("Richard L", "Advanced Math", "section 1.1", "problems 8-12");

        // Console.WriteLine(assignment.GetSummary());
        // Console.WriteLine(assignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Mauricio Sanchez", "American History", "The effects of the Civil War");

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());

    }
}