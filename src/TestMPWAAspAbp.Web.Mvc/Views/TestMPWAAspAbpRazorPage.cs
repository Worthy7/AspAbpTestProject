using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace TestMPWAAspAbp.Web.Views
{
    public abstract class TestMPWAAspAbpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected TestMPWAAspAbpRazorPage()
        {
            LocalizationSourceName = TestMPWAAspAbpConsts.LocalizationSourceName;
        }
    }
}
