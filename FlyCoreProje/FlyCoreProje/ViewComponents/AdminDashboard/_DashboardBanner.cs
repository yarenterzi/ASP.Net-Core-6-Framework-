using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
namespace FlyCoreProje.ViewComponents.AdminDashboard
{
    public class _DashboardBanner:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
         return View();
        }
    }
}
