using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2Project
{
    public interface IRepo
    {
        void Create(Contact contact);
        List<Contact> ReadAll();
        Contact ReadByEmail(string email);
        void Update(string email, Contact contact);
        void DeleteByEmail(string email);


    }
}
