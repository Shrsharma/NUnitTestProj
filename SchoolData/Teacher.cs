using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolData
{
    

    public class Teacher
    {
        public string Name { get; set; }
        public string ClassandSection { get; set; }

        public static List<Teacher> teachers = new List<Teacher>();
        public static string TeachAddData()
        {
            Teacher t1 = new Teacher()
            {
                Name = "Ms.Yagami",
                ClassandSection = "X-A"
            };
            teachers.Add(t1);
            return "Teacher Data Added";
        }

        public static List<Teacher> GetTeachList()
        {
            return teachers;
        }
    }

}
