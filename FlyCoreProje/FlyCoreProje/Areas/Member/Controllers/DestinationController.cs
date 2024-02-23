using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlyCoreProje.Areas.Member.Controllers
{
    [AllowAnonymous]
    [Area("Member")]
    public class DestinationController : Controller
    {
        DestinationManager destinationmanager = new DestinationManager(new
            EfDestinationDal());
        public IActionResult Index()
        {
            var values = destinationmanager.TGetList();
            return View(values);
        }

    }
}
