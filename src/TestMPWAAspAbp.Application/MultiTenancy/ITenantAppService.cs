using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TestMPWAAspAbp.MultiTenancy.Dto;

namespace TestMPWAAspAbp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

