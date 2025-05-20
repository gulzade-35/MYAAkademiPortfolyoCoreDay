using Microsoft.AspNetCore.Mvc;
using PortfolioCoreDay.Context;
using PortfolioCoreDay.Entities;

namespace PortfolioCoreDay.Controllers
{
	public class SocialMediaController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult SocialMediaList()
		{
			var values = context.SocialMedias.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult AddSocialMedia()
		{

			return View();
		}
		[HttpPost]
		public IActionResult AddSocialMedia(SocialMedia socialMedia)
		{
			var values = context.SocialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var values = context.SocialMedias.Find(id);
			context.SocialMedias.Remove(values);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var values = context.SocialMedias.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			var values = context.SocialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
	}
}
