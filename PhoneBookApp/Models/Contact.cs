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

        
        /* When creating a relationship between entities, can use ICollection<T> and it will take anything that implements ICollection<T>.
        Therefore, we can use List<T> or HashSet<T> depending on what our data will look like because they both implement the methods from
        ICollection<T> */
        public List<Number> Numbers { get; set; } // Navigation (collection) property
    }
}
