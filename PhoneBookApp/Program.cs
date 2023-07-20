using PhoneBookApp.Data;
using PhoneBookApp.Models;

using PhoneBookContext _context = new();

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
//var numbers = _context.Contacts
//                    .Where(n => 

//foreach (Contact c in contacts)
//{
//    Console.WriteLine($"First name: {c.FirstName}");
//    Console.WriteLine($"Last name: {c.LastName}");
//    Console.WriteLine($"Phone number: {c.Numbers[2].PhoneNumber}");
//}