using System.Threading.Tasks;
using TestMPWAAspAbp.Configuration.Dto;

namespace TestMPWAAspAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
