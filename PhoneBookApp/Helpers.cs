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
    public class Helpers
    {
        UserInput input = new();
        Validate validate = new();
        public void AddContact()
        {
            Console.Clear();
            using PhoneBookContext _context = new();

            var contact = new Contact
            {
                FirstName = input.GetFirstName(),
                LastName = input.GetLastName(),
                Numbers = new List<Number>()
                {
                    new()
                    {
                        PhoneNumber = input.GetPhone(),
                        Description = input.GetDescription(),
                    }
                }   
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void ShowContacts()
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

        public void UpdateContact()
        {
            using PhoneBookContext _context = new();

            var userInput = input.GetUserId();
            var intId = validate.IdInput(userInput);

           _context.Contacts
                .Where(c => c.Id == intId)
                .ExecuteUpdate(s => s
                    .SetProperty(c => c.FirstName, c => input.GetFirstName())
                    .SetProperty(c => c.LastName, c => input.GetLastName()));

           _context.Numbers
                .Where(n => n.Id == intId)
                .ExecuteUpdate(s => s
                    .SetProperty(n => n.PhoneNumber, n => input.GetPhone())
                    .SetProperty(n => n.Description, n => input.GetDescription()));
        }

        public void DeleteContact()
        {
            using PhoneBookContext _context = new();

            var userInput = input.GetDeleteId();
            var intId = validate.IdInput(userInput);

            // Using ExecuteDelete is easier than having to manually remove the blog and save the changes, ExecuteDelete does it in one line
            var result = _context.Contacts.Where(c => c.Id == intId).ExecuteDelete();
            if (result == 0)
            {
                Console.WriteLine("Id does not exist.");
            }
            else Console.WriteLine("Id was successfully deleted. Enter any key to go back to the main menu.");
            Console.ReadLine();
        }
    }
}
