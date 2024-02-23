using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FlyCoreProje.ViewComponents.Default
{
    //Manager da atanan içi dolu crud için işlem çağırılır 
    public class _PopularDestinations:ViewComponent
    {
        DestinationManager destinationManager = new DestinationManager (new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
