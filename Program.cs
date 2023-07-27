using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
            Console.ReadKey();
        }
        static void doApp()
        {
            // Working with strings
            string firstName = "John";
            string lastName = "Doe";

            // Concatenation
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Full Name: " + fullName);

            // String interpolation 
            string interpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine("Interpolated Full Name: " + interpolatedFullName);

            // Length of the string
            int fullNameLength = fullName.Length;
            Console.WriteLine("Full Name Length: " + fullNameLength);

            // Substring
            string partialName = fullName.Substring(0, 4);
            Console.WriteLine("Partial Name: " + partialName);

            // IndexOf
            int indexOfSpace = fullName.IndexOf(" ");
            if (indexOfSpace != -1)
            {
                string firstNameOnly = fullName.Substring(0, indexOfSpace);
                Console.WriteLine("First Name Only: " + firstNameOnly);
            }

            // Working with StringBuilder
            StringBuilder stringBuilder = new StringBuilder();

            // Appending to StringBuilder
            stringBuilder.Append("This ");
            stringBuilder.Append("is ");
            stringBuilder.Append("a ");
            stringBuilder.Append("sentence.");
            Console.WriteLine("StringBuilder Output: " + stringBuilder.ToString());

            // Modifying StringBuilder
            stringBuilder.Replace("sentence", "new sentence");
            Console.WriteLine("Modified StringBuilder: " + stringBuilder.ToString());
        }
    }
}
