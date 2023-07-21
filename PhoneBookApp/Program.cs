using PhoneBookApp;
using PhoneBookApp.Data;
using PhoneBookApp.Models;

using PhoneBookContext _context = new();

Menu menu = new Menu();
menu.showMenu();

//var contact = new Contact
//{
//    FirstName = "Jane",
//    LastName = "Doe",
//    Numbers = new List<Number>()
//    {
//        new()
//        {
//            PhoneNumber = "132-492-9582",
//            Description = "Coworker"
//        }
//    }
//};

//_context.Contacts.Add(contact);
//await _context.SaveChangesAsync();

//var contacts = _context.Contacts
//                    .Where(c => c.FirstName == "Jane");

//var numbers = _context.Numbers
//                    .Single(n => n.Id == 2);

//foreach (Contact c in contacts)
//{
//    Console.WriteLine($"First name: {c.FirstName}");
//    Console.WriteLine($"Last name: {c.LastName}");
//}

//Console.WriteLine($"Phone number: {numbers.PhoneNumber}");
//Console.WriteLine($"Description: {numbers.Description}");