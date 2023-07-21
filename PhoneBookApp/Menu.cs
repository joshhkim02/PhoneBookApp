﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    internal class Menu
    {
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
                        Console.WriteLine("Adding new contact...");
                        break;
                    case "2":
                        Console.WriteLine("Viewing existing contacts...");
                        break;
                    case "3":
                        Console.WriteLine("Updating existing contact...");
                        break;
                    case "4":
                        Console.WriteLine("Deleting contact...");
                        break;
                    case "5":
                        Console.WriteLine("Exiting application...");
                        closeApp = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Enter any key to try again.");
                        Console.ReadLine();
                        showMenu();
                        break;
                }
            }
        }
    }
}
