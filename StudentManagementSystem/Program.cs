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

                Console.Write("Please select an option: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Error: Please enter a valid number!");
                    continue;
                }


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
                            Console.WriteLine("Student inserted successfully!");
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
                            Console.WriteLine("There is no student!");
                        }
                        else
                        {
                            Console.WriteLine("ID\tName Surname\tGrade");
                            Console.WriteLine("----------------------------------------");
                            foreach (Student student in studentList)
                            {
                                Console.Write($"{student.ID}");
                                Console.Write($"\t{student.Name}");
                                Console.Write($" {student.Surname}");
                                Console.WriteLine($"\t{student.Grade}");
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
                            Console.WriteLine($"\t{student.Grade}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error:{ex.Message}");
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
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Please enter a numerical value!");
                        }
                        break;
                    case 5:
                        try
                        {
                            Console.WriteLine("Please enter the student ID to update.");
                            int updateID = int.Parse(Console.ReadLine());
                            Console.WriteLine("Please enter the new grade:");
                            double newGrade = double.Parse(Console.ReadLine());
                            manager.Update(updateID, newGrade);
                            Console.WriteLine("Student updated successfully!");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Error: Please enter a numerical value!");
                        }
                        catch(ArgumentException ex)
                        {
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        break;
                    case 6:
                        try
                        {
                            double max=manager.Max();
                            Console.WriteLine($"Max grade:{max}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        break;
                    case 7:
                        try
                        {
                            double average = manager.Average();
                            Console.WriteLine($"Average grade:{average:F2}");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Error:{ex.Message}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again!");
                        break;
                }
            }
        }
    }
}
