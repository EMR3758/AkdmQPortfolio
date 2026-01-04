using Microsoft.AspNetCore.Mvc;
//Kütüphaneleri çağırıyor.

namespace AkdmQPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
