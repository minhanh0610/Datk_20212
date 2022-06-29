using System.Configuration;
using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace Datk
{
    [DependsOn(typeof(DatkCoreModule), typeof(AbpAutoMapperModule))]
    public class DatkApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            
        }

        
    }
}
