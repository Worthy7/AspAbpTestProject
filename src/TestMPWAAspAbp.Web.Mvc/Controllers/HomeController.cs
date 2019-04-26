using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using TestMPWAAspAbp.Controllers;

namespace TestMPWAAspAbp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestMPWAAspAbpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
