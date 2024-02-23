using Microsoft.AspNetCore.Mvc;

namespace FlyCoreProje.Areas.Member.Controllers
{
	public class MessageController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
