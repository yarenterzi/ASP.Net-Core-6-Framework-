using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FlyCoreProje.ViewComponents.MemberLayout
{
    public class _MemberLayoutHead:ViewComponent
    {
       public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
