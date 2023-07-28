using PhoneBookApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public class Validate
    {
        userInput user = new();
        public int IdInput(string input)
        {
            int intId;
            bool result = int.TryParse(input, out intId);

            if (result == false)
            {
                Console.WriteLine("Input is invalid. Enter any key to go back to the main menu.");
                Console.ReadLine();
            }
            return intId;
        }

        public void IdExists(int input)
        {
            using PhoneBookContext _context = new();

            // Get the number of rows returned from select query
            var rowsReturned = _context.Contacts.Where(c => c.Id == input).Count();

            // if rowsReturned = 0, then that means there were no hits with the query
            if (rowsReturned == 0)
            {
                Console.WriteLine("Id does not exist. Enter any key to go back to the main menu.");
                Console.ReadLine();
            }
        }
        
        public void FirstName(string input)
        {
            
        }
    }
}
