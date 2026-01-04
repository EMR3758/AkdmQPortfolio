using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Create metodu için get fonksiyonu
        public IActionResult CreateExperience()
        {
            return View();
        }

        //Güncelleme için get fonksiyonu
        public IActionResult UpdateExperience()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult UpdateExperience()
        //{
        //    //buraya veri tabanına kaydetmek için gerekli kodlar gelecek

        //}


        public IActionResult DeleteExperience()
        {
            return View(); 
        }
        
    }
}
