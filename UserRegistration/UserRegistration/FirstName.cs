using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class FirstName
    {
        public static string firstName = "^[A-Z][a-z]{3}$";
        public static void validateFirstName(string userFirstName)
        {
            if (Regex.IsMatch(userFirstName, firstName))
            {
                Console.WriteLine("It Is A Valid First Name");
            }
            else
            {
                Console.WriteLine("You Entered Invalid First Name");
            }
        }
    }
}
