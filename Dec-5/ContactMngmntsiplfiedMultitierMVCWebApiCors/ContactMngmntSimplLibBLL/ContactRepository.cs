using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactMngmntSimplLibDAL;

namespace ContactMngmntSimplLibBLL
{
    public  class ContactRepository
    {
        private SimplifiedContactManagementSystemEntities ctx = new SimplifiedContactManagementSystemEntities();
        public List<Contact> GetContacts()
        {
            return ctx.Contacts.ToList();
        }       
     }
}
