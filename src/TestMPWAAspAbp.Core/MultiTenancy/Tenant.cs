using Abp.MultiTenancy;
using TestMPWAAspAbp.Authorization.Users;

namespace TestMPWAAspAbp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
