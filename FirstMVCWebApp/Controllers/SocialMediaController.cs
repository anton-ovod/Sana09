using Microsoft.AspNetCore.Mvc;

namespace FirstMVCWebApp.Controllers
{
    public class SocialMediaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Facebook()
        {
            return View();
        }

        public IActionResult Twitter()
        {
            return View();
        }

        public IActionResult Instagram()
        {
            return View();
        }
    }
}
