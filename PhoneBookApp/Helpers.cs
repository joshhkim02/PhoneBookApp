using Microsoft.EntityFrameworkCore;
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

            Console.WriteLine("OPTIONAL: Enter in a description for the contact:");
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

        public void showContacts()
        {
            using PhoneBookContext _context = new();

            var contacts = _context.Contacts.ToList();

            var numbers = _context.Numbers.ToList();

            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            for (int i = 0; i < contacts.Count; i++)
            {
                Console.WriteLine($"Contact ID: {contacts[i].Id}");
                Console.WriteLine($"Name: {contacts[i].FirstName} {contacts[i].LastName}");
                Console.WriteLine($"Phone number: {numbers[i].PhoneNumber}");
                Console.WriteLine($"Description: {numbers[i].Description}\n");
            }
            Console.WriteLine("-----------------------------------------");
        }

        public async void updateContact()
        {
            using PhoneBookContext _context = new();
            int intId;

            Console.WriteLine("Enter in the ID of the contact you would like to edit.");
            var userId = Console.ReadLine();

            bool result = int.TryParse(userId, out intId);

            while (result == false)
            {
                Console.WriteLine("Please enter in a valid number.");
                userId = Console.ReadLine();
                result = int.TryParse(userId, out intId);
            }

            Console.WriteLine("\nEnter in the first name of the contact:");
            var newFirstName = Console.ReadLine();

            Console.WriteLine("\nEnter in the last name of the contact: ");
            var newLastName = Console.ReadLine();

            Console.WriteLine("\nEnter in the phone number of the contact: ");
            var newPhoneNumber = Console.ReadLine();

            Console.WriteLine("\nOPTIONAL: Enter in a description for the contact:");
            var newDescription = Console.ReadLine();

            await _context.Contacts
                .Where(c => c.Id == intId)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(c => c.FirstName, c => newFirstName)
                    .SetProperty(c => c.LastName, c => newLastName));

            await _context.Numbers
                .Where(n => n.Id == intId)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(n => n.PhoneNumber, n => newPhoneNumber)
                    .SetProperty(n => n.Description, n => newDescription));

            await _context.SaveChangesAsync();
        }
    }
}
