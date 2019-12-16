using System.Linq;
using BlogProject.DAL.Database;
using BlogProject.Entities;

namespace BlogProject.DAL.Management
{
    public class AboutManagement
    {
        private ProjectContext database;

        public AboutManagement()
        {
            database=new ProjectContext();
        }
        public AboutPage GetAboutPage()
        {
            var model = database.AboutPage.FirstOrDefault();
            return model;
        }
    }
}
