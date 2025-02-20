using Microsoft.AspNetCore.Mvc;

namespace SingInd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
