using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        School school1 = new School();
        school1._name = "BYUI";
        school1._numStudents = 32000;
        school1._numTeachers = 500;

        Student student1 = new Student();
        student1._name = "Bill Alexander";

        school1._student = new System.Collections.Generic.List<Student>();
        school1._student.Add(student1);

        school1.ShowDetails();

        School school2 = new School();
        school2._name = "BYU";
        school2._numStudents = 40000;
        school2._numTeachers = 700;

        school2.ShowDetails();
    }
}
