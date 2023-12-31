﻿using Microsoft.EntityFrameworkCore;
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
        /* In this case, the DBContext is NOT injected as it is a transient service. The Helpers class has been added as a singleton in Program.cs,
           so by injecting the DBContext into this class, DBContext loses its transient property and is 'promoted' into a singleton. As a reuslt,
           the new instance is only going to be created once. */

        private readonly UserInput _input;
        private readonly Validate _validate;
        public Helpers(UserInput input, Validate validate)
        {
            _input = input;
            _validate = validate;
        }

        public void AddContact()
        {
            // We have a new using statement for every method that uses the context for reasons mentioned above and since EF Core supports lightweight transactions
            using PhoneBookContext _context = new();
            Console.Clear();
            var contact = new Contact
            {
                FirstName = _input.GetFirstName(),
                LastName = _input.GetLastName(),
                Numbers = new List<Number>()
                {
                    new()
                    {
                        PhoneNumber = _input.GetPhone(),
                        Description = _input.GetDescription(),
                    }
                }   
            };
            _context.Contacts.Add(contact);
            _context.SaveChanges();
        }

        public void ShowContacts()
        {
            using PhoneBookContext _context = new();
            Console.Clear();
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
            var userInput = _input.GetUserId();
            var intId = _validate.IdInput(userInput);

           _context.Contacts
                .Where(c => c.Id == intId)
                .ExecuteUpdate(s => s
                    .SetProperty(c => c.FirstName, c => _input.GetFirstName())
                    .SetProperty(c => c.LastName, c => _input.GetLastName()));

           _context.Numbers
                .Where(n => n.Id == intId)
                .ExecuteUpdate(s => s
                    .SetProperty(n => n.PhoneNumber, n => _input.GetPhone())
                    .SetProperty(n => n.Description, n => _input.GetDescription()));
        }

        public void DeleteContact()
        {
            using PhoneBookContext _context = new();
            var userInput = _input.GetDeleteId();
            var intId = _validate.IdInput(userInput);

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
