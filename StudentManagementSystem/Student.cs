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
        public double Grade { get; set; }
        public Student(int id ,string name,string surname,double grade)           
        {
            ID = id;
            Name = name;
            Surname = surname;
            Grade = grade;
        }
    }
}
