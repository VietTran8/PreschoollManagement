using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PreschollManagement;
using PreschollManagement.Controller;


namespace UnitTest
{
    [TestClass]
    public class AccountTest
    {
        [TestMethod]
        public void ValidAccountTest()
        {
            string username = "admin2";
            string password = "admin";
            int expected, actual;

            expected = 0;
            
            actual = AccountController.validateAccount(username, password);

            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void InvalidAccountTest()
        {
            string username = "admin20000";
            string password = "admin";
            int expected, actual;

            expected = -1;

            actual = AccountController.validateAccount(username, password);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidCreateAccountTest()
        {
            string username = "admin9000";
            string password = "admin";
            int role = 0;
            string expected, actual;

            expected = "Tạo tài khoản thành công";

            actual = AccountController.createAccount(username, password, role);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void InvalidCreateAccountTest()
        {
            string username = "admin2";
            string password = "admin";
            int role = 0;
            string expected, actual;

            expected = "Tên tài khoản đã tồn tại!";

            actual = AccountController.createAccount(username, password, role);

            Assert.AreEqual(expected, actual);
        }
    }
}
