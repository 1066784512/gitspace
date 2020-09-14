using Abp;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using Lxk.Ucenter.Web.Core.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Lxk.Ucenter.Web.Host.Controllers
{
    public class HomeController : LxkControllerBase
    {

        public IActionResult Index()
        {
            return Redirect("/swagger");
        }

    }
}