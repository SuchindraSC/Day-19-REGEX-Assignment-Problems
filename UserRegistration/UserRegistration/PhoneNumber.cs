using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class PhoneNumber
    {
        public static string phoneNumber = "([1-9]{2})+[ ][1-9]+([0-9]{9})";
        public static void validatePhoneNumber(string userPhoneNumber)
        {
            if (Regex.IsMatch(userPhoneNumber, phoneNumber))
            {
                Console.WriteLine("It Is A Valid Phone Number");
            }
            else
            {
                Console.WriteLine("You Entered Invalid Phone Number");
            }
        }
    }
}
