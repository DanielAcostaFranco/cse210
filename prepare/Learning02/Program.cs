using System;

class Program
{
    static void Main(string[] args)
    // {
    //     Job job1 = new Job();

    //     job1._company = "Amazon";

    //     job1._jobTitle = "Software Engineer";

    //     job1._startYear = 2020;

    //     job1._endYear = 2023;


    //     Job job2 = new Job();

    //     job2._company = "Apple";

    //     job2._jobTitle = "Software Engineer";

    //     job2._startYear = 2023;

    //     job2._endYear = 2025;


    //     Resume Resume1 = new Resume();
    //     Resume1._name = "Daniel Acosta";

    //     Resume1._jobs.Add(job1);
    //     Resume1._jobs.Add(job2);

    //     Resume1.DisplayJobDetails();
    // }

    {
        while (true)
        {
            Console.WriteLine("Enter your name: ");
            Resume newResume = new Resume();
            newResume._name = Console.ReadLine();

            while (true)

            {
                Job job = new Job();

                Console.Write("Enter the company: ");
                job._company = Console.ReadLine();

                Console.WriteLine("Enter the job title: ");
                job._jobTitle = Console.ReadLine();

                Console.WriteLine("Enter the start year: ");
                job._startYear = Console.ReadLine();

                Console.WriteLine("Enter the end year: ");
                job._endYear = Console.ReadLine();

                newResume._jobs.Add(job);

                Console.Write("Add another job? y/n: ");

                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "n") break;

            }


            Console.Write("Would you like to add another resume? y/n :");

            string answer2 = Console.ReadLine().Trim().ToLower();
            if (answer2 == "n") break;


            Console.WriteLine("Resume Details: ");
            newResume.DisplayJobDetails();




        }
    }


}