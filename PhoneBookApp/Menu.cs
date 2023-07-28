using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class Menu
    {
        Helpers helpers = new();
        public void ShowMenu()
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
                        helpers.AddContact();
                        break;
                    case "2":
                        helpers.ShowContacts();
                        Console.WriteLine("Enter any key to go back to the main menu.");
                        Console.ReadLine();
                        break;
                    case "3":
                        helpers.ShowContacts();
                        helpers.UpdateContact();
                        break;
                    case "4":
                        helpers.ShowContacts();
                        helpers.DeleteContact();
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
