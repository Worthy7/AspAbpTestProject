using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace TestMPWAAspAbp.Controllers
{
    public abstract class TestMPWAAspAbpControllerBase: AbpController
    {
        protected TestMPWAAspAbpControllerBase()
        {
            LocalizationSourceName = TestMPWAAspAbpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
