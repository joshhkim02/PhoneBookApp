using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Data;
using PhoneBookApp.Models;
using PhoneBookApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class Helpers
    {
        userInput input = new();
        internal void addContact()
        {
            using PhoneBookContext _context = new();

            var contact = new Contact
            {
                FirstName = input.getFirstName(),
                LastName = input.getLastName(),
                Numbers = new List<Number>()
                {
                    new()
                    {
                        PhoneNumber = input.getPhone(),
                        Description = input.getDescription(),
                    }
                }   
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        internal void showContacts()
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
                // We access phone number and description through the Numbers property in contact
                foreach (var num in contact.Numbers)
                {
                    Console.WriteLine($"Phone number: {num.PhoneNumber}");
                    Console.WriteLine($"Description: {num.Description}\n");
                }
            }
            Console.WriteLine("-----------------------------------------");
        }

        internal void updateContact()
        {
            using PhoneBookContext _context = new();
            int intId;

            var userInput = input.getUserId();

            bool result = int.TryParse(userInput, out intId);

            while (result == false)
            {
                Console.WriteLine("Please enter in a valid number.");
                userInput = input.getUserId();
                result = int.TryParse(userInput, out intId);
            }

           _context.Contacts
                .Where(c => c.Id == intId)
                .ExecuteUpdate(s => s
                    .SetProperty(c => c.FirstName, c => input.getFirstName())
                    .SetProperty(c => c.LastName, c => input.getLastName()));

           _context.Numbers
                .Where(n => n.Id == intId)
                .ExecuteUpdate(s => s
                    .SetProperty(n => n.PhoneNumber, n => input.getPhone())
                    .SetProperty(n => n.Description, n => input.getDescription()));
        }

        internal void deleteContact()
        {
            using PhoneBookContext _context = new();
            int intId;

            Console.WriteLine("Enter in the ID of the contact you would like to delete.");
            var userId = Console.ReadLine();

            bool result = int.TryParse(userId, out intId);

            while (result == false)
            {
                Console.WriteLine("Please enter in a valid number.");
                userId = Console.ReadLine();
                result = int.TryParse(userId, out intId);
            }

            // Using ExecuteDelete is easier than having to manually remove the blog and save the changes, ExecuteDelete does it in one line
            _context.Contacts.Where(c => c.Id == intId).ExecuteDelete();
        }
    }
}
