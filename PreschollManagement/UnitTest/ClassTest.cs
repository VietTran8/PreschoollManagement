using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PreschollManagement;
using PreschollManagement.Controller;

namespace UnitTest
{
    [TestClass]
    public class ClassTest
    {
        [TestMethod]
        public void addClassTest()
        {
            string className = "Test";
            string room = "Test";
            string classLevel = "Test";
            string schoolYearFrom = "Test";
            string schoolYearTo = "Test";

            string expected, actual;
            expected = "Thêm lớp học thành công!";

            actual = ClassController.addClass(className, room, classLevel, schoolYearFrom, schoolYearTo);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void updateClassTest()
        {
            string classId = "L0020";
            string className = "Test1";
            string room = "Test1";
            string classLevel = "Test1";
            string schoolYearFrom = "Test1";
            string schoolYearTo = "Tes";

            string expected, actual;
            expected = "Cập nhật lớp học thành công!";

            actual = ClassController.updateClass(classId, className, room, classLevel, schoolYearFrom, schoolYearTo);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void deleteClassTest()
        {
            string classId = "L0016";

            string expected, actual;
            expected = "Xóa lớp học thành công!";

            actual = ClassController.deleteClass(classId);

            Assert.AreEqual(expected, actual);
        }
    }
}
