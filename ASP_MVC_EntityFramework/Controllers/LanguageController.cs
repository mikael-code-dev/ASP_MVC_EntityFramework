using Microsoft.AspNetCore.Mvc;

namespace ASP_MVC_EntityFramework.Controllers
{
    public class LanguageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
