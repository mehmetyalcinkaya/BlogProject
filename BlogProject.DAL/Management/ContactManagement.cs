using System.Linq;
using BlogProject.DAL.Database;
using BlogProject.Entities;

namespace BlogProject.DAL.Management
{
    public class ContactManagement
    {
        private ProjectContext database;

        public ContactManagement()
        {
            database = new ProjectContext();
        }

        public ContactPage GetContactManagement()
        {
            var model = database.ContactPage.FirstOrDefault();
            return model;
        }
    }
}
