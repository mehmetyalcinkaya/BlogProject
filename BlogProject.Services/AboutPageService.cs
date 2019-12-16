using BlogProject.DAL.Database;
using BlogProject.DAL.Management;
using BlogProject.Entities;

namespace BlogProject.Services
{
    public class AboutPageService
    {
        private AboutManagement _aboutManagement;

        public AboutPageService()
        {
            _aboutManagement = new AboutManagement();
        }

        public AboutPage GetAboutPage()
        {
            var model = _aboutManagement.GetAboutPage();
            return model;
        }
    }
}
