using System.Threading.Tasks;
using Abp.Application.Services;
using TestMPWAAspAbp.Sessions.Dto;

namespace TestMPWAAspAbp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
