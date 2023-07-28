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
                Console.WriteLine("Input is invalid. Enter any key to try again.");
                Console.ReadLine();
            }
            return intId;
        }

        public void IdExists(int input)
        {
            using PhoneBookContext _context = new();
            bool doesExist;

            _context.Contacts.Where(c => c.Id == input);


        }
        
        public void FirstName(string input)
        {
            
        }
    }
}
