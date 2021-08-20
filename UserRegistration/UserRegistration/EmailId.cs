using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class EmailId
    {
        public static string emailId = @"^([a-z]{3})+[\.+]([a-z]{3,})+@([a-z]{2})+[\.+]([a-z]{2})+[\.+]([a-z]{2,})$";
        public static void validateEmailId(string userEmailId)
        {
            if (Regex.IsMatch(userEmailId, emailId))
            {
                Console.WriteLine("It Is A Valid Email Id");
            }
            else
            {
                Console.WriteLine("You Entered Invalid Email Id");
            }
        }
    }
}
