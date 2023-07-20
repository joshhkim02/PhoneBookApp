using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;   // Setting to "null!" tells compiler this cannot be null
        public string LastName { get; set; } = null!;
        public List<Number> Numbers { get; set; } = null!; // Navigation (collection) property
    }
}
