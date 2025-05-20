using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
    public class SendMessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        [HttpPost]
        public IActionResult SendMessages(Message message)
        {
            context.Messages.Add(message);
            context.SaveChanges();
            ViewBag.Success = "Gönderim işlemi başarılı!";
            return View("~/Views/Default/Index.cshtml");
        }
    }
}
