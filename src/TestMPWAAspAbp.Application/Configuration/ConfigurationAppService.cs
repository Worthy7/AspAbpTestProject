using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using TestMPWAAspAbp.Configuration.Dto;

namespace TestMPWAAspAbp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : TestMPWAAspAbpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
