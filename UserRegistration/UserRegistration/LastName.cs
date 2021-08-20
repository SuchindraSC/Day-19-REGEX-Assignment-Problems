using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class LastName
    {
        public static string lastName = "^[A-Z][a-z]{3}$";
        public static void validateLastName(string userLastName)
        {
            if (Regex.IsMatch(userLastName, lastName))
            {
                Console.WriteLine("It Is A Valid Last Name");
            }
            else
            {
                Console.WriteLine("You Entered Invalid Last Name");
            }
        }
    }
}
