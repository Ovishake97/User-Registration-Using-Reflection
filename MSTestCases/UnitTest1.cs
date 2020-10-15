using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationReflection;

namespace MSTestCases
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenProperEmailShouldReturnSucess()
        {
            string pattern= "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            string actual = UserValidation.ValidateDetails("abc.xyz@mgmail.com", pattern);
            Assert.AreEqual("The format is valid", actual);
        }
        [TestMethod]
        public void GivenEmptyEmailShouldThrowError() {
            try
            {
                string pattern = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
                string actual = UserValidation.ValidateDetails(" ", pattern);
            }
            catch (UserRegistrationCustomException exceptions) {
                Assert.AreEqual("User data cannot be empty", exceptions.Message);
            }
        }
    }
}
