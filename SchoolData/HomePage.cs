using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolData
{
    public class HomePage
    {
        public static void Do()
        {
            Console.WriteLine("This is Home Page.\n\n  Do you wanna do something?(Y/N) ");
            string ans = Console.ReadLine();
            bool flag = false;

            if (ans == "Y" || ans == "y")
            {
                flag = true;

                while (flag)
                {
                    Console.WriteLine("\n 1)Do you wanna add new student data  \n 2) Do you wanna add teacher data   \n 3)Do you wanna add subject data  \n 4)Do you wanna display student data  \n 5) Do you display teacher data   \n 6)Do you wanna display subject data");
                    string res = Console.ReadLine();
                    if (res == "1")
                    {
                        Student.StudAddData();
                    }
                    else if (res == "2")
                    {
                        Teacher.TeachAddData();
                    }
                    else if (res == "3")
                    {
                        SubjectInfo.SubAddData();
                    }
                    else if (res == "4")
                    {
                        Console.WriteLine("Show Student data");
                        List<Student> data = Student.GetStudList();
                        foreach (Student ele in data)
                        {
                            Console.WriteLine("Name:{0}  ||  Class and Section:{1}", ele.Name, ele.ClassAndSection);
                        }
                    }
                    else if (res == "5")
                    {
                        Console.WriteLine("Show Teacher data");
                        List<Teacher> data = Teacher.GetTeachList();
                        foreach (Teacher ele in data)
                        {
                            Console.WriteLine("Name:{0}  ||  Class and Section:{1}", ele.Name, ele.ClassandSection);
                        }
                    }
                    else if (res == "6")
                    {
                        Console.WriteLine("Show subject data");
                        List<Subject> data = SubjectInfo.getSubList();
                        foreach (Subject ele in data)
                        {
                            Console.WriteLine("Name:{0}  ||  Subject Code:{1}", ele.Name, ele.SubjectCode);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n~~~No such option~~~");
                    }
                    Console.WriteLine("\nDo you wanna do anything more?(Y/N):");
                    string ask = Console.ReadLine();
                    if (ask == "Y" || ask == "y")
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                        Console.WriteLine("\n\n THE END");
                    }


                }
            }

            else
            {
                Console.WriteLine("\n\nOK BYE!!");
            }
        }
    }
}
