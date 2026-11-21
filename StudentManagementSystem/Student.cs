using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    internal class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        private double _grade;

        public double Grade
        {
            get { return _grade; }

            set
            {
                if (value >= 0 && value <= 100)
                {
                    _grade = value;
                }
                else
                {
                    throw new ArgumentException("Grade must be between 0 and 100!");
                }
            }
        }

        public Student(int id, string name, string surname, double grade)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Grade = grade;
        }
    }
}
