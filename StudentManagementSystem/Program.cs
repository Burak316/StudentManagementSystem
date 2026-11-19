namespace StudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentManager manager = new StudentManager();
            bool running = true;

            while (running)
            {
                Console.WriteLine("----------Student Management System----------");
                Console.WriteLine("1-Insert Student");
                Console.WriteLine("2-Listing Student");
                Console.WriteLine("3-Searching Student");
                Console.WriteLine("4-Deleting Student");
                Console.WriteLine("5-Update Student");
                Console.WriteLine("6-Find Max Grade");
                Console.WriteLine("7-Find Average Grade");
                Console.WriteLine("0-Exit");

                int choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine("Please enter a new ID");
                            int id = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter a name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Please enter a surname");
                            string surname = Console.ReadLine();
                            Console.WriteLine("Please enter a grade");
                            double grade = double.Parse(Console.ReadLine());
                            Student newStudent = new Student(id, name, surname, grade);
                            manager.Insert(newStudent);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Please enter a numerical value!");
                        }
                        break;
                    case 2:
                        List<Student> studentList = manager.Listing();
                        if (studentList.Count == 0)
                        {
                            Console.Write("There is no student!");
                        }
                        else
                        {
                            Console.WriteLine("ID\tName Surname\tGrade");
                            Console.WriteLine("----------------------------------------");
                            foreach (Student student in manager.Listing())
                            {
                                Console.Write($"{student.ID}");
                                Console.Write($"\t{student.Name}");
                                Console.Write($" {student.Surname}");
                                Console.Write($"\t{student.Grade}");
                                Console.WriteLine("---------------------------------------");
                            }
                        }
                        break;
                    case 3:
                        try
                        {
                            Console.WriteLine("Please enter the student ID to search.");
                            int searchID = int.Parse(Console.ReadLine());
                            Student student = manager.Searching(searchID);
                            Console.WriteLine("ID\tName Surname\tGrade");
                            Console.WriteLine("----------------------------------------");
                            Console.Write($"{student.ID}");
                            Console.Write($"\t{student.Name}");
                            Console.Write($" {student.Surname}");
                            Console.Write($"\t{student.Grade}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Please enter a numerical value!");
                        }
                        break;
                    case 4:
                        try
                        {
                            Console.WriteLine("Please enter the student ID to delete.");
                            int deleteID = int.Parse(Console.ReadLine());
                            manager.Deleting(deleteID);
                            Console.WriteLine("Student deleted successfully!");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"{ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Please enter a numerical value!");
                        }
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 0:
                        break;
                    default:
                        break;
                }



            }
        }
    }
}
