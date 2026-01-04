using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.ViewComponents
{
    public class SkillViewComponent : ViewComponent
    {   
        public IViewComponentResult Invoke()
        { 
            return View();
        }

    }
}
