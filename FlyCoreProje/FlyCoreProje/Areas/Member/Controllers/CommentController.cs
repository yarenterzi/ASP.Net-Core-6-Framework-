using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlyCoreProje.Areas.Member.Controllers
{   
	[Area("Member")]
	[AllowAnonymous]
	public class CommentController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
