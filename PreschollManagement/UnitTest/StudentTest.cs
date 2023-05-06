using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PreschollManagement.Controller;

namespace UnitTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void addStudentTest()
        {
            string classId = "L0003";
            string firstName = "Test";
            string lastName = "Test";
            int gender = 1;
            string birthDay = "28-04-2019";
            string ethinicity = "Test";
            string religion = "Test";
            string address = "Test";
            string hometown = "Test";
            string parentName = "Test";
            string parentPhone = "Test";

            string expected = "Thêm hồ sơ thành công";
            string actual = StudentController.addStudent(classId, firstName, lastName, gender, birthDay, ethinicity, religion, address, hometown, parentName, parentPhone);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void updateStudentTest()
        {
            string studentId = "HS0008";
            string classId = "L0008";
            string firstName = "Test1";
            string lastName = "Test2";
            int gender = 1;
            string birthDay = "28-04-2019";
            string ethinicity = "Test";
            string religion = "Test";
            string address = "Test";
            string hometown = "Test";
            string parentName = "Test";
            string parentPhone = "Test";

            string expected = "Cập nhật hồ sơ thành công";
            string actual = StudentController.updateStudent(studentId, classId, firstName, lastName, gender, birthDay, ethinicity, religion, address, hometown, parentName, parentPhone);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void deleteStudentTest()
        {
            string studentId = "HS0008";

            string expected = "Xóa học sinh thành công!";
            string actual = StudentController.deleteStudent(studentId);

            Assert.AreEqual(expected, actual);
        }
    }
}
