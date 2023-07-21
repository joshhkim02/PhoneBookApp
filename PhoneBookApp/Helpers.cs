using PhoneBookApp.Data;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class Helpers
    {
        public async void addContact()
        {
            using PhoneBookContext _context = new();

            Console.WriteLine("Enter in the first name of the contact:");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter in the last name of the contact: ");
            var lastName = Console.ReadLine();

            Console.WriteLine("Enter in the phone number of the contact: ");
            var phoneNumber = Console.ReadLine();

            Console.WriteLine("OPTIONAL: Enter in a description for the number:");
            var description = Console.ReadLine();

            var contact = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                Numbers = new List<Number>()
                {
                    new()
                    {
                        PhoneNumber = phoneNumber,
                        Description = description
                    }
                }
            };
            _context.Contacts.Add(contact);
            await _context.SaveChangesAsync();
        }
    }
}
