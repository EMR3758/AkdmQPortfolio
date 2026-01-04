using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.ViewComponents
{
    public class AdminHeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
