using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Password
    {
        public static string password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[!*@#$%^&+=]).{8,}$";
        public static void validatePassword1(string userPassword)
        {

                if (Regex.IsMatch(password, userPassword))
            {
                Console.WriteLine("It Is Valid Password");
            }
            else
            {
                Console.WriteLine("You Entered Invalid Password");
            }
        }

    }
}
