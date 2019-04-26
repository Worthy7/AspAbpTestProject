using Abp.AutoMapper;
using TestMPWAAspAbp.Sessions.Dto;

namespace TestMPWAAspAbp.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
