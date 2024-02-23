using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FlyCoreProje.ViewComponents.MemberDashboard
{
    public class _ProfileInformation:ViewComponent
    {
        public _ProfileInformation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        private readonly UserManager<AppUser> _userManager;
        public async Task< IViewComponentResult> InvokeAsync()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.memberName = values.UserName + " " + values.SurName;
            ViewBag.memberPhone = values.PhoneNumber;
            ViewBag.memberEmail = values.Email;

            return View();
        }
    }
}
