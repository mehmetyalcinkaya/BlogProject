using System.Web.Mvc;
using BlogProject.Entities;
using BlogProject.Services;

namespace BlogProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AboutPageService aboutPageService;
        private readonly ContactPageService contactPageService;

        public HomeController()
        {
            aboutPageService = new AboutPageService();
            contactPageService = new ContactPageService();
        }
        
        [HttpGet]
        public ActionResult Index() => View();

        [HttpGet]
        public ActionResult About()
        {
            
            AboutPage about = aboutPageService.GetAboutPage();
            return View(about);
        }

        [HttpGet]
        public ActionResult Contact()
        {

            ContactPage contact = contactPageService.GetContactPage();

            if (contact == null)
                return View("_NotFound");
            
            return View(contact);
        }
    }
}