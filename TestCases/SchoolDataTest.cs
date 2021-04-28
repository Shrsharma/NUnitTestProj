using Moq;
using NUnit.Framework;
using SchoolData;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestCases
{
    [TestFixture()]
    public class SchoolDataTest
    {

        [Test()]
        public void AddStudentTest()
        {
            //Assert
            Student student = new Student()
            {
                 Name = "Shruti",
                ClassAndSection = "X-A"
            };
            string expResult = "Student Data Added";

            //Act
            string result = Student.StudAddData();

            //Assert
            Assert.AreEqual(expResult, result);

        }

        [Test()]
        public void GetStudentTest()
        {
            var result = Student.GetStudList();

            Assert.IsTrue(result.Count == 1);
        }

        [Test()]
        public void DelStudentTest()
        {
            //Arrange
            Student student = new Student()
            {
                Name = "Shruti",
                ClassAndSection = "X-A"
            };

            //Act
            var result = Student.StudDelData(student);

            //Assert
            Assert.IsTrue(result);
        }

        [Test()]
        public void AddTeacherTest()
        {
            //Assert
            Teacher teacher = new Teacher()
            {
                Name = "Ms.Yagami",
                ClassandSection = "X-A"
            };
            string expResult = "Teacher Data Added";

            //Act
            string result = Teacher.TeachAddData();

            //Assert
            Assert.AreEqual(expResult, result);

        }

        [Test()]
        public void GetTeacherTest()
        {
            var result = Teacher.GetTeachList();

            Assert.IsTrue(result.Count == 1);
        }


    }
}
