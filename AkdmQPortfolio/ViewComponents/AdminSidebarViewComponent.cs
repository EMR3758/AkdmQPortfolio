using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.ViewComponents
{
    public class AdminSidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        }
    }
}
