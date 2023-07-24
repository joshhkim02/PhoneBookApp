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
            Console.Clear();
            using PhoneBookContext _context = new();

            // Include the Numbers property (List type) from model so we can access it 
            var contacts = _context.Contacts.Include(contact => contact.Numbers).ToList();

            Console.WriteLine("-----------------------------------------");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"Contact ID: {contact.Id}");
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}");
                foreach (var num in contact.Numbers)
                {
                    Console.WriteLine($"Phone number: {num.PhoneNumber}");
                    Console.WriteLine($"Description: {num.Description}\n");
                }
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

            var query1 = await _context.Contacts
                .Where(c => c.Id == intId)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(c => c.FirstName, c => newFirstName)
                    .SetProperty(c => c.LastName, c => newLastName));

           var query2 = await _context.Numbers
                .Where(n => n.Id == intId)
                .ExecuteUpdateAsync(s => s
                    .SetProperty(n => n.PhoneNumber, n => newPhoneNumber)
                    .SetProperty(n => n.Description, n => newDescription));
        }
    }
}
