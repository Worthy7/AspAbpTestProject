using Microsoft.AspNetCore.Antiforgery;
using TestMPWAAspAbp.Controllers;

namespace TestMPWAAspAbp.Web.Host.Controllers
{
    public class AntiForgeryController : TestMPWAAspAbpControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
