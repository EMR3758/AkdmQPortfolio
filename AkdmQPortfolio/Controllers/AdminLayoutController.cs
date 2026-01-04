using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
