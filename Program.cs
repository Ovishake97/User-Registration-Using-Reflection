using System;
using System.Security.Cryptography.X509Certificates;

namespace UserRegistrationReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the User Registration Portal");
            Console.WriteLine("------------------------------");
            const string EMAIL_PATTERN = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Console.WriteLine("Enter the email of the user");
            string email = Console.ReadLine();
            string result = UserValidation.ValidateDetails(email, EMAIL_PATTERN);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
