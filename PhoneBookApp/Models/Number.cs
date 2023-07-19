using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Models
{
    public class Number
    {
        public int NumberId { get; set; }
        public int ContactId { get; set; }
        public int PhoneNumber { get; set; }
        public string Description { get; set; }
    }
}
