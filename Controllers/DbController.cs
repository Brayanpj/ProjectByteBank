using Microsoft.AspNetCore.Mvc;

namespace ProjectBank.Controllers
{
    public class DbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
