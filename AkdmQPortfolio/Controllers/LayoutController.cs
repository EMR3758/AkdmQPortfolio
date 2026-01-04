using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

//Layout hiçbir zaman tek başına çalışamaz. --> renderBody() --> bizim sonradan oluşturacağımız içerik sayfalarını buranın içine atıyor.

//yetenekler sayfasındaki herşey renderBody içinde yer alacak