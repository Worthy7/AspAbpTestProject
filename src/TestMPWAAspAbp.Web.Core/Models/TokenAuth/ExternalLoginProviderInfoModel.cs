using Abp.AutoMapper;
using TestMPWAAspAbp.Authentication.External;

namespace TestMPWAAspAbp.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
