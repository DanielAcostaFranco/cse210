using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new MathAssignment();
        assignment1.setStudent("Daniel");
        assignment1.setTopic("Algebra");
        assignment1.SetHomeworkList("Section 5.4", "Problems 9-20");


        Console.WriteLine(assignment1.GetMathAssignment());

        WritingAssignment assignment2 = new WritingAssignment();
        assignment2.setStudent("Daniel");
        assignment2.setTopic("Information Technology");
        assignment2.SetWritingInformation("The invention of the Computer");


        Console.WriteLine(assignment2.GetWritingAssignment());

        

    }
}