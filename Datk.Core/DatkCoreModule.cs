using System.Reflection;
using Abp.Modules;

namespace Datk
{
    public class DatkCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = DatkConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
