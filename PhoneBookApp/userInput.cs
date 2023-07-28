using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class UserInput
    {
        public string GetFirstName()
        {
            Console.WriteLine("Enter in the first name of the contact:");
            var firstName = Console.ReadLine();
            return firstName;
        }

        public string GetLastName()
        {
            Console.WriteLine("Enter in the last name of the contact: ");
            var lastName = Console.ReadLine();
            return lastName;
        }

        public string GetPhone()
        {
            Console.WriteLine("Enter in the phone number of the contact: ");
            var phoneNumber = Console.ReadLine();
            return phoneNumber;
        }

        public string GetDescription()
        {
            Console.WriteLine("OPTIONAL: Enter in a description for the contact:");
            var description = Console.ReadLine();
            return description;
        }

        public string GetUserId()
        {
            Console.WriteLine("Enter in the ID of the contact you would like to edit.");
            var userId = Console.ReadLine();
            return userId;
        }

        public string GetDeleteId()
        {
            Console.WriteLine("Enter in the ID of the contact you would like to delete.");
            var userId = Console.ReadLine();
            return userId;
        }
    }
}
