using System;

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student("Daniel", "1234");
        Schedule schedule = new Schedule(student);

        Boolean keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("1. Display");
            Console.WriteLine("2. Add Course");
            Console.WriteLine("3. Update Course");
            Console.WriteLine("Choose an option: ");

            string response = Console.ReadLine();

            if (response == "1")
            {
                schedule.Display();
            } else if (response == "2")
            {
                Console.WriteLine("Which course?");
                string courseNumber = Console.ReadLine();
                Course course = new Course(courseNumber, 0, 0, "M, W");
                schedule.AddCourse(course);
            }
        }

    }
}