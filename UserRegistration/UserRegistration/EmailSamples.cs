using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class EmailSamples
    {
        public static string SampleEmailId = @"^[A-Za-z0-9]+([\.+\-_][A-Za-z0-9]+)*@[a-zA-Z0-9]+[\.?+][A-Za-z]+[\.?+][A-Za-z]{2,}$";
        public static void validateSampleEmailId()
        {
            string[] userSampleEmailId = new string[]
            {
                "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au",
                "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@gmail.com.aa.au", "abc@gmail.com.1a", "abc@abc@gmail.com"
            };
            for (int i = 0; i < userSampleEmailId.Length; i++)
            {
                if (Regex.IsMatch(SampleEmailId, userSampleEmailId[i]))
                {
                    Console.WriteLine("Valid Email Id Is {0}",userSampleEmailId[i]);
                }
                else
                {
                    Console.WriteLine("Invalid Email Id Is {0}",userSampleEmailId[i]);
                }
            }
        }
    }
}
