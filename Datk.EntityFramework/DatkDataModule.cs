using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using Datk.EntityFramework;

namespace Datk
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(DatkCoreModule))]
    public class DatkDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<DatkDbContext>(null);
        }
    }
}
