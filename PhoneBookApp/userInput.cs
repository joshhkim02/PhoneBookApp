using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class userInput
    {
        internal string getFirstName()
        {
            Console.WriteLine("Enter in the first name of the contact:");
            var firstName = Console.ReadLine();
            return firstName;
        }

        internal string getLastName()
        {
            Console.WriteLine("Enter in the last name of the contact: ");
            var lastName = Console.ReadLine();
            return lastName;
        }

        internal string getPhone()
        {
            Console.WriteLine("Enter in the phone number of the contact: ");
            var phoneNumber = Console.ReadLine();
            return phoneNumber;
        }

        internal string getDescription()
        {
            Console.WriteLine("OPTIONAL: Enter in a description for the contact:");
            var description = Console.ReadLine();
            return description;
        }
    }
}
