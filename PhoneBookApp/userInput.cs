using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class userInput
    {
        public string getFirstName()
        {
            Console.WriteLine("Enter in the first name of the contact:");
            var firstName = Console.ReadLine();
            return firstName;
        }

        public string getLastName()
        {
            Console.WriteLine("Enter in the last name of the contact: ");
            var lastName = Console.ReadLine();
            return lastName;
        }

        public string getPhone()
        {
            Console.WriteLine("Enter in the phone number of the contact: ");
            var phoneNumber = Console.ReadLine();
            return phoneNumber;
        }

        public string getDescription()
        {
            Console.WriteLine("OPTIONAL: Enter in a description for the contact:");
            var description = Console.ReadLine();
            return description;
        }

        public string getUserId()
        {
            Console.WriteLine("Enter in the ID of the contact you would like to edit.");
            var userId = Console.ReadLine();
            return userId;
        }

        public string getDeleteId()
        {
            Console.WriteLine("Enter in the ID of the contact you would like to delete.");
            var userId = Console.ReadLine();
            return userId;
        }
    }
}
