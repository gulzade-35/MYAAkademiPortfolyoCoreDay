using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            //var values = context.Statistics.ToList();
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Portfolios.Count();
            ViewBag.v3 = context.Messages.Count();
           
            Random random = new Random();
            int randomNumber = random.Next(10, 21); // 10 dahil, 21 hariç
            ViewBag.v4 = randomNumber;
            return View();
        }
    }
}
