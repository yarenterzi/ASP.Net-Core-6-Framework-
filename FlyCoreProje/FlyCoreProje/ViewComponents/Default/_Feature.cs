using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace FlyCoreProje.ViewComponents.Default
{
    //Manager da atanan içi dolu crud için işlem çağırılır 
    public class _Feature:ViewComponent
    {
      FeatureManager featureManager = new FeatureManager(new EfFeatureDal());
          public IViewComponentResult Invoke()
        {
         //   var values = featureManager.TGetList();
       //  ViewBag.image1=featureManager.ge
            return View();
        }
    }
}
