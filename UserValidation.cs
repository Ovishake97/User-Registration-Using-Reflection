using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

namespace UserRegistrationReflection
{
    public class UserValidation
    {

        public static string ValidateDetails(string data,string pattern) {
            try
            {
                if (data.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_FIELD, "User data cannot be empty");
                }
                else if (pattern.Equals(string.Empty)) {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_PATTERN, "Regex pattern cannot be empty");
                }
                else {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type datatype = executing.GetType("UserRegistrationReflection.UserValidation");
                    object dataInstance = Activator.CreateInstance(datatype);
                    MethodInfo dataMethod = datatype.GetMethod("CheckPattern");
                    string[] parameters = new string[2] { "Data", "Pattern" };
                    return (string)dataMethod.Invoke(dataInstance, parameters);
                }   
            }
            catch (NullReferenceException) {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_REFERENCE, "Fields cannot be null");
            }
        }

        public string CheckPattern(string data, string pattern) {
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(pattern))
            {
                return "The format is valid";
            }
            else {
                return "The format is invalid";
            }
        }
    }
}
