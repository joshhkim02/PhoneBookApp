using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class Menu
    {
        Helpers helpers = new();
        internal void showMenu()
        {
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Welcome to your phonebook!");
                Console.WriteLine("Enter 1 to add a new contact.");
                Console.WriteLine("Enter 2 to view existing contacts.");
                Console.WriteLine("Enter 3 to update an existing contact.");
                Console.WriteLine("Enter 4 to delete a contact.");
                Console.WriteLine("Enter 5 to exit the application.");
                Console.WriteLine("-----------------------------------------");

                var userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        helpers.addContact();
                        break;
                    case "2":
                        helpers.showContacts();
                        Console.WriteLine("Enter any key to go back to the main menu.");
                        Console.ReadLine();
                        break;
                    case "3":
                        helpers.showContacts();
                        helpers.updateContact();
                        break;
                    case "4":
                        helpers.showContacts();
                        helpers.deleteContact();
                        break;
                    case "5":
                        Console.WriteLine("Exiting application...");
                        closeApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Enter any key to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
