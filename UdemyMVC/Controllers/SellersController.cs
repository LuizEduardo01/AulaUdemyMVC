using Microsoft.AspNetCore.Mvc;

namespace UdemyMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
