using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    public interface IHelpers
    {
        void AddContact();
        void ShowContacts();
        void UpdateContact();
        void DeleteContact();
    }
}
