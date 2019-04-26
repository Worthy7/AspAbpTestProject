using System.Threading.Tasks;
using Abp.Application.Services;
using TestMPWAAspAbp.Authorization.Accounts.Dto;

namespace TestMPWAAspAbp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
