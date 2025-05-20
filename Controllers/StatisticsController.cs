using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;

namespace PortfolioCoreDay.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {
            //Yetenek Sayısı
            ViewBag.v0 = "+++++++";
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue);
            ViewBag.v3 = context.Skills.Average(x => x.SkillValue);
            ViewBag.v4 = context.Skills.Where(x => x.SkillValue > 80).Count();
            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Services.Count();
            ViewBag.v7 = context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.v8 = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.v9 = context.Portfolios.Count();
            ViewBag.v10 = context.Messages.Count();

            ////Proje Sayısı
            //ViewBag.v5 = context.Portfolios.Count();

            ////Gelen Mesaj Sayısı
            //ViewBag.v6 = context.Messages.Count();

            ////Rastgele Sayısı

            //Random rnd = new Random();
            //int random = rnd.Next(10, 30);
            //ViewBag.v7 = random;

            return View();
        }
    }
}
