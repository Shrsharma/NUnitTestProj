﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchoolData
{
    
    
    public class Student
    {
        public string Name { get; set; }
        public string ClassAndSection { get; set; }

        public static List<Student> students = new List<Student>();
        public static string StudAddData()
        {
            //Console.WriteLine("Enter student name:");
            //string nme = Console.ReadLine();
            //Console.WriteLine("Enter student Class and Section:");
            //string clssndsctn = Console.ReadLine();
            Student s1 = new Student()
            {
                Name = "Shruti",
                ClassAndSection = "X-A"
            };
            students.Add(s1);
            return "Student Data Added";
        }

        public static List<Student> GetStudList()
        {
            return students;
        }

        public static bool StudDelData(Student student)
        {
            var removeSuccess = false;
            var findStudent = students.Find(s => s.Name == student.Name);
            if (findStudent != null)
            {
                removeSuccess = students.Remove(findStudent);
            }
            return removeSuccess;
        }
    }

}
