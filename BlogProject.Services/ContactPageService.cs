using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogProject.DAL.Management;
using BlogProject.Entities;

namespace BlogProject.Services
{
    public class ContactPageService
    {
        private ContactManagement _contactManagement;

        public ContactPageService()
        {
            _contactManagement = new ContactManagement();
        }

        public ContactPage GetContactPage()
        {
            var model = _contactManagement.GetContactManagement();
            return model;
        }
    }
}
