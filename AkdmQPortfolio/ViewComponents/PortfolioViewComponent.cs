using Microsoft.AspNetCore.Mvc;

namespace AkdmQPortfolio.ViewComponents
{
    public class PortfolioViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
