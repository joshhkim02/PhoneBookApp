using PhoneBookApp.Data;
using PhoneBookApp.Models;

using PhoneBookContext context = new();

Contact JohnDoe = new Contact()
{
    // ContactId will be 1
    FirstName = "John",
    LastName = "Doe"
};
context.Contacts.Add(JohnDoe);

Number JDoe = new()
{
    ContactId = 1,
    PhoneNumber = "313-3942-3013",
    Description = "Co-worker"
};
context.Numbers.Add(JDoe);

context.SaveChanges();