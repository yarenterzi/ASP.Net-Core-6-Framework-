using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace FlyCoreProje.ViewComponents.Default
{
    //Manager da atanan içi dolu crud için işlem çağırılır 
    public class _SubAbout:ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());

        public IViewComponentResult Invoke()
        {
            var values=subAboutManager.TGetList();
            return View(values);
        }
    }
}
