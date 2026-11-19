using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagementSystem
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        #region insert
        public void Insert(Student newStudent)
        {

            foreach (Student existingStudent in students)
            {
                if (newStudent.ID == existingStudent.ID)
                {
                    throw new InvalidOperationException("This ID number is already registered");
                }
            }
            students.Add(newStudent);

        }
        #endregion
        #region listing
        public List<Student> Listing()
        {
            return students;
        }
        #endregion
        #region searching
        public Student Searching(int searchingID)
        {
            foreach (Student existingStudent in students)
            {
                if (existingStudent.ID == searchingID)
                {
                    return existingStudent;
                }
            }
            throw new InvalidOperationException($"{searchingID} not found!");
        }
        #endregion
        #region deleting
        public void Deleting(int deleteID)
        {
            Student existingStudent = Searching(deleteID);
            students.Remove(existingStudent);
        }
        #endregion
        #region update
        public void Update(int updateID, double newGrade)
        {
            Student existingStudent = Searching(updateID);
            existingStudent.Grade = newGrade;
        }
        #endregion
        #region max
        public double Max()
        {
            if (students.Count == 0)
            {
                throw new InvalidOperationException("There is no student");
            }

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
        #endregion
        #region average
        public double Average()
        {
            if (students.Count == 0)
            {
                throw new InvalidOperationException("There is no student!");
            }

            double sum = 0;
            foreach (Student student in students)
            {
                sum += student.Grade;
            }
            return sum / (students.Count);

        }
        #endregion




    }
}
