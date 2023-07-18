using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Models
{
    internal class Contact
    {
        public int Id { get; set; }
        // Set Name and PhoneNumber to null with null forgiving operator as we do not want these fields to be empty
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null;
    }
}
