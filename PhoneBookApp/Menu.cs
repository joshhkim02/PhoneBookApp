﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class Menu
    {
        private readonly Helpers _helpers;
        public Menu(Helpers helpers) => _helpers = helpers;
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
                        _helpers.AddContact();
                        break;
                    case "2":
                        _helpers.ShowContacts();
                        Console.WriteLine("Enter any key to go back to the main menu.");
                        Console.ReadLine();
                        break;
                    case "3":
                        _helpers.ShowContacts();
                        _helpers.UpdateContact();
                        break;
                    case "4":
                        _helpers.ShowContacts();
                        _helpers.DeleteContact();
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
