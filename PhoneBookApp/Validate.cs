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
    }
}
        