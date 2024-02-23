using Microsoft.AspNetCore.Mvc;

namespace FlyCoreProje.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
