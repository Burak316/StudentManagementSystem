using StudentManagementSystem;
using System;
class Program
{
    static void Main(string[] args)
    {
        StudentManager manager = new StudentManager();
       
        Console.WriteLine("\tStudent System");
        Console.WriteLine("------------------------------");
        bool running = true;
        while (running)
        {
            Console.WriteLine("Please select the action you wish to perform.");
            Console.WriteLine("1-Insert");
            Console.WriteLine("2-List");
            Console.WriteLine("3-Search");
            Console.WriteLine("4-Delete");
            Console.WriteLine("5-Average");
            Console.WriteLine("6-Max");
            Console.WriteLine("7-Update");
            Console.WriteLine("8-Exit");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    manager.Insert();
                    break;
                case 2:
                    manager.Listing();
                    break;
                case 3:
                    manager.Searching();
                    break;
                case 4:
                    manager.Deleting();
                    break;
                case 5:
                    double average = manager.Average();
                    if (average != 0)
                        Console.WriteLine($"Average grade is:{average}");
                    break;
                case 6:
                    double max = manager.Max();
                    if (max != 0)
                        Console.WriteLine($"Max grade is:{max}");
                    break;
                case 7:
                    manager.Update();
                    break;
                case 8:
                    Console.WriteLine("Exiting...");
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice try again");
                    continue;

            }
        }
    }
}
