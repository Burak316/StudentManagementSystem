using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void Insert()
        {
            while (true)
            {

                Console.WriteLine("Please enter ID");
                int id = int.Parse(Console.ReadLine());

                bool exists = false;
                foreach (Student student in students)
                {
                    if (student.ID == id)
                    {
                        exists = true;
                        break;
                    }
                }
                if (exists)
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
                    Student newStudent = new Student(id, name, surname, grade);
                    students.Add(newStudent);
                }
                Console.WriteLine("Press 1 to continue or -1 to exit");
                int isContinue = int.Parse(Console.ReadLine());
                if (isContinue == -1)
                    break;
            }

        }

        public void Listing()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("There is no student");
                return;
            }
            Console.WriteLine("ID\tname surname\tgrade");
            Console.WriteLine("----------------------------------------");


            for (int index = 0; index < students.Count; index++)
            {

                Console.Write(students[index].ID);
                Console.Write("\t");
                Console.Write(students[index].Name);
                Console.Write(" ");
                Console.Write(students[index].Surname);
                Console.Write("\t");
                Console.WriteLine(students[index].Grade);
                Console.WriteLine("----------------------------------------");

            }
        }
        public void Searching()
        {

            Console.WriteLine("please enter ıd who you want to search");
            int searchID = int.Parse(Console.ReadLine());

            int index = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == searchID)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                Console.WriteLine("Invalid ID");
            else
            {
                Console.Write(students[index].ID);
                Console.Write("\t");
                Console.Write(students[index].Name);
                Console.Write(" ");
                Console.Write(students[index].Surname);
                Console.Write("\t");
                Console.WriteLine(students[index].Grade);
            }
        }
        public void Deleting()
        {
            Console.WriteLine("please enter ıd who you want to delete");
            int deleteID = int.Parse(Console.ReadLine());

            int index = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == deleteID)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                Console.WriteLine("Invalid ID");
            else
            {
                students.RemoveAt(index);
                Console.WriteLine("Student deleted successfully!");
            }
        }
        public double Average()
        {
            int count = students.Count;
            if (count == 0)
            {
                Console.WriteLine("There is no student");
                return 0;
            }

            else
            {
                double sum = 0;
                foreach (Student student in students)
                {
                    sum += student.Grade;
                }
                double average = sum / count;
                return average;
            }
        }
        public double Max()
        {
            if (students.Count <= 0)
            {
                Console.WriteLine("There is no student");
                return 0;
            }

            else
            {
                double max = students[0].Grade;

                foreach (Student student in students)
                {
                    if (max < student.Grade)
                    {
                        max = student.Grade;

                    }
                }
                return max;
            }
        }
        public void Update()
        {
            Console.WriteLine("Enter the ID you wish to update.");
            int updateID = int.Parse(Console.ReadLine());

            int index = -1;
            for (int i = 0; i < students.Count; i++)
            {
                if (students[i].ID == updateID)
                {
                    index = i;
                    break;
                }
            }

            if (index == -1)
                Console.WriteLine("Invalid id");
            else
            {
                Console.WriteLine(
                    students[index].ID +
                    "\t" +
                    students[index].Name +
                    " " +
                    students[index].Surname +
                    "\t" +
                    students[index].Grade
                    );

                Console.WriteLine("Enter new grade");
                double newGrade = double.Parse(Console.ReadLine());
                if (newGrade < 0 || newGrade > 100)
                    Console.WriteLine("Invalid grade");
                else
                {
                    students[index].Grade = newGrade;
                    Console.WriteLine("Updated.");
                }
            }
        }




    }
}
