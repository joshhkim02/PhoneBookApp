using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Models
{
    public class Number
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; } = null!; // We do NOT want the phone number to be left blank
        public string? Description { get; set; } // Description can be empty


        // Reference navigations
        public int ContactId { get; set; } // Recognized as foreign key because it matches pattern <navigation property>Id
        public Contact Contact { get; set; } = null!; // Navigation (reference) property
    }
}
