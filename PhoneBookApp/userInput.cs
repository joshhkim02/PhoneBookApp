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

        internal string getUserId()
        {
            Console.WriteLine("Enter in the ID of the contact you would like to edit.");
            var userId = Console.ReadLine();
            return userId;
        }

        internal string deleteId()
        {
            Console.WriteLine("Enter in the ID of the contact you would like to delete.");
            var userId = Console.ReadLine();
            return userId;
        }

        internal int validateInput(string input)
        {
            int intId;
            bool result = int.TryParse(input, out intId);

            while (result == false)
            {
                Console.WriteLine("Please enter in a valid number.");
                input = getUserId();
                result = int.TryParse(input, out intId);
            }
            return intId;
        }
    }
}
