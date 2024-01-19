using BusinessCardVisualizer.Models;
using Microsoft.AspNetCore.Mvc;

namespace BusinessCardVisualizer.Controllers
{
	public class BusinessCardController : Controller
	{
		private UserDataModel defaultUser;

		public BusinessCardController()
		{
			defaultUser = new UserDataModel()
			{
				Name = "Ivan Petrov",
				Position = "WebDeveloper",
				Phone = "+39566776677",
				Email = "ivan.petrov@gmail.com",
				Company = "Samsung"
			};
		}
		public IActionResult Index()
		{
			return View(defaultUser);
		}

		[HttpPost]
		public IActionResult EditCard(UserDataModel model) 
		{
			if (!ModelState.IsValid)
			{
				return View("Index", model);
			}

			ViewBag.Title = "YourCard";

			return View("Index", model);
		}
	}
}
