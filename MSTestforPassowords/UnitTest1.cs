using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationReflection;

namespace MSTestforPassowords
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenProperPasswordShouldReturnSucess()
        {
            string pattern = "[a-zA-Z0-9]{8,}";
            string actual = UserValidation.ValidateDetails("Pasword123", pattern);
            Assert.AreEqual("The format is valid", actual);
        }
        [TestMethod]
        public void GivenEmptyPasswordShouldThrowError()
        {
            try
            {
                string pattern = "[a-zA-Z0-9]{8,}";
                string actual = UserValidation.ValidateDetails(" ", pattern);
            }
            catch (UserRegistrationCustomException exceptions)
            {
                Assert.AreEqual("User data cannot be empty", exceptions.Message);
            }
        }
    }
}
