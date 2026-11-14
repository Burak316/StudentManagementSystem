using System;
class Program
{


    static void Insert(
    List<int> IDs,
    List<string> names,
    List<string> surnames,
    List<double> grades)
    {
        while (true)
        {
            Console.WriteLine("Please enter ID");
            int ID = int.Parse(Console.ReadLine());
            if (IDs.Contains(ID))
            {
                Console.WriteLine("This ID is already registered!");
                continue;
            }
            Console.WriteLine("Please enter name");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter Surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Please enter grade");
            double grade = double.Parse(Console.ReadLine());
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("invalid grade");
                continue;
            }
            else
            {
                IDs.Add(ID);
                names.Add(name);
                surnames.Add(surname);
                grades.Add(grade);
            }
            Console.WriteLine("Press 1 to continue or -1 to exit");
            int isContinue = int.Parse(Console.ReadLine());
            if (isContinue == -1)
                break;
        }
    }
    static void Listing(
    List<int> IDs,
    List<string> names,
    List<string> surnames,
    List<double> grades)
    {
        Console.WriteLine("ID\tname surname\tgrade");
        Console.WriteLine("----------------------------------------");


        for (int index = 0; index < IDs.Count; index++)
        {

            Console.Write(IDs[index]);
            Console.Write("\t");
            Console.Write(names[index]);
            Console.Write(" ");
            Console.Write(surnames[index]);
            Console.Write("\t");
            Console.WriteLine(grades[index]);
            Console.WriteLine("----------------------------------------");

        }
    }
    static void Searching(
     List<int> IDs,
    List<string> names,
    List<string> surnames,
    List<double> grades)
    {

        Console.WriteLine("please enter ıd who you want to search");
        int searchID = int.Parse(Console.ReadLine());
        int index = IDs.IndexOf(searchID);
        if (index == -1)
            Console.WriteLine("Invalid ID");
        else
        {
            Console.Write(IDs[index]);
            Console.Write("\t");
            Console.Write(names[index]);
            Console.Write(" ");
            Console.Write(surnames[index]);
            Console.Write("\t");
            Console.WriteLine(grades[index]);
        }
    }
    static void Deleting(
    List<int> IDs,
    List<string> names,
    List<string> surnames,
    List<double> grades)
    {
        Console.WriteLine("please enter ıd who you want to delete");
        int deleteID = int.Parse(Console.ReadLine());
        int index = IDs.IndexOf(deleteID);
        if (index == -1)
            Console.WriteLine("Invalid ID");
        else
        {
            IDs.RemoveAt(index);
            names.RemoveAt(index);
            surnames.RemoveAt(index);
            grades.RemoveAt(index);
            Console.WriteLine("Student deleted successfully!");
        }
    }
    static double Average(
    List<double> grades)
    {
        int count = grades.Count;
        if (count == 0)
        {
            Console.WriteLine("There is no student");
            return 0;
        }

        else
        {
            double sum = 0;
            foreach (double grade in grades)
            {
                sum += grade;
            }
            double average = sum / count;
            return average;
        }
    }
    static double Max(List<double> grades)
    {
        if (grades.Count <= 0)
        {
            Console.WriteLine("There is no student");
            return 0;
        }

        else
        {
            double max = 0.0;

            foreach (double grade in grades)
            {
                if (max < grade)
                {
                    max = grade;

                }
            }
            return max;
        }
    }
    static void Update(List<int> IDs,
    List<string> names,
    List<string> surnames,
    List<double> grades)
    {
        Console.WriteLine("Enter the ID you wish to update.");
        int updateID = int.Parse(Console.ReadLine());

        int index = IDs.IndexOf(updateID);

        if (index == -1)
            Console.WriteLine("invalid id");
        else
        {
            Console.WriteLine(IDs[index] + "\t" + names[index] + " " + surnames[index] + "\t" + grades[index]);

            Console.WriteLine("yeni notu giriniz");
            double newGrade = double.Parse(Console.ReadLine());
            if (newGrade < 0 || newGrade > 100)
                Console.WriteLine("invalid grade");
            else
            {
                grades[index] = newGrade;
                Console.WriteLine("güncellendi");
            }
        }
    }
    static void Main(string[] args)
    {
        List<int> IDs = new List<int>();
        List<string> names = new List<string>();
        List<string> surnames = new List<string>();
        List<double> grades = new List<double>();

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
                    Insert(IDs, names, surnames, grades);
                    break;
                case 2:
                    Listing(IDs, names, surnames, grades);
                    break;
                case 3:
                    Searching(IDs, names, surnames, grades);
                    break;
                case 4:
                    Deleting(IDs, names, surnames, grades);
                    break;
                case 5:
                    double average = Average(grades);
                    if (average != 0)
                        Console.WriteLine($"Average grade is:{average}");
                    break;
                case 6:
                    double max = Max(grades);
                    if (max != 0)
                        Console.WriteLine($"Max grade is:{max}");
                    break;
                case 7:
                    Update(IDs, names, surnames, grades);
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
