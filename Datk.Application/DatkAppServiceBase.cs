using Abp.Application.Services;

namespace Datk
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class DatkAppServiceBase : ApplicationService
    {
        protected DatkAppServiceBase()
        {
            LocalizationSourceName = DatkConsts.LocalizationSourceName;
        }
    }
}