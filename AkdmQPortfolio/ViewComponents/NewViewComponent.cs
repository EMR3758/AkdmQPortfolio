using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.ViewComponents
{
    public class NewViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View(); 
        }
    }
}
