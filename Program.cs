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
            const string PASSWORD_PATTERN = "[a-zA-Z0-9]{8,}";
            Console.WriteLine("Enter the email of the user");
            string email = Console.ReadLine();
            string resultOne = UserValidation.ValidateDetails(email, EMAIL_PATTERN);
            Console.WriteLine(resultOne);
            Console.WriteLine("Enter the password of the user");
            string password = Console.ReadLine();
            string resultTwo = UserValidation.ValidateDetails(password,PASSWORD_PATTERN);
            Console.WriteLine(resultTwo);
            Console.ReadKey();
        }
    }
}
