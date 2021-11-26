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
        [Test]
        private void TestValidateEmail (string email, bool expectedResult)
        {
            var accountController = new AccountController();

            var actualResults = accountController.ValidateEmail(email);

            Assert.AreEqual(expectedResult, actualResults);

        }
    }
}
