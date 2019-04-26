using Abp.AspNetCore.Mvc.ViewComponents;

namespace TestMPWAAspAbp.Web.Views
{
    public abstract class TestMPWAAspAbpViewComponent : AbpViewComponent
    {
        protected TestMPWAAspAbpViewComponent()
        {
            LocalizationSourceName = TestMPWAAspAbpConsts.LocalizationSourceName;
        }
    }
}
