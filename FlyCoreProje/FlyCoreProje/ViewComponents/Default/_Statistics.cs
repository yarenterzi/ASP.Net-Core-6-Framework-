﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FlyCoreProje.ViewComponents.Default
{
    //Manager da atanan içi dolu crud için işlem çağırılır 
    public class _Statistics:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new Context();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2=c.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
