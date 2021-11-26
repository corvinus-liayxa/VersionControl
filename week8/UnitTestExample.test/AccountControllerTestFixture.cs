using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.test
{
    class AccountControllerTestFixture
    {
        [Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)]
        public void TestValidateEmail (string email, bool expectedResult)
        {
            var accountController = new AccountController();

            var actualResults = accountController.ValidateEmail(email);

            Assert.AreEqual(expectedResult, actualResults);

        }


        [Test,
            TestCase("kukaK",false),
            TestCase("KUKA12", false),
            TestCase("kuka12", false),
            TestCase("1",false),
            TestCase("megFekeleo12",true)]

        public void TestPassword(string password, bool expectedResult)
        {
            var accountController = new AccountController();

            var actualResults = accountController.ValidatePassword(password);

            Assert.AreEqual(expectedResult, actualResults);

        }
    }
}
