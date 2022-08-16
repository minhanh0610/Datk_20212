using Abp.MultiTenancy;
using Datk.Authorization.Users;


namespace Datk.MultiTenancy
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
