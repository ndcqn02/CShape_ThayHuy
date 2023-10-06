using Microsoft.AspNetCore.Mvc;

namespace Practice_Template1.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
