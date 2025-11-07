using System;

public class Menu
{
    public void StartMenu()
    {
        int totalactivities = 0;
        string choice = "";

        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Start breathing activity.");
            Console.WriteLine("2. Start reflecting activity.");
            Console.WriteLine("3. Start listing activity.");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing activity = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Good job!");
                activity.StartMessage(); 
                activity.Run();
                activity.EndMessage();   
                totalactivities++;
            }
            else if (choice == "2")
            {
                Reflection activity = new Reflection("Reflection","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.","Great reflection!");
                activity.StartMessage();
                activity.Run();
                activity.EndMessage();
                totalactivities++;
            }
            else if (choice == "3")
            {
                Listing activity = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.","Nice work!");
                activity.StartMessage();
                activity.Run();
                activity.EndMessage();
                totalactivities++;
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                Console.WriteLine($"You completed a total of: {totalactivities} activities.");
            }
            else
            {
                Console.WriteLine("Please choose a valid option.");
            }
        }
    }
}
