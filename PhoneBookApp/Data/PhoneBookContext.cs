using Microsoft.EntityFrameworkCore;
using PhoneBookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp.Data
{
    public class PhoneBookContext :DbContext
    {
        // Each DbSet maps to a table that will be created in the database
        public DbSet<Number> Numbers { get; set; } = null!;
        public DbSet<Contact> Contacts { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\PhoneBookDB;Database=PhoneBook;Trusted_Connection=True");
        }
    }
}
