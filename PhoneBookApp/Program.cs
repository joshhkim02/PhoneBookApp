using PhoneBookApp.Data;
using PhoneBookApp.Models;

using PhoneBookContext _context = new();

var contact = new Contact
{
    FirstName = "Jane",
    LastName = "Doe",
    Numbers = new List<Number>()
    {
        new()
        {
            PhoneNumber = "132-492-9582",
            Description = "Coworker"
        }
    }
};

_context.Contacts.Add(contact);
await _context.SaveChangesAsync();

