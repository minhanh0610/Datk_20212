using Abp.Web.Mvc.Controllers;

namespace Datk.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class DatkControllerBase : AbpController
    {
        protected DatkControllerBase()
        {
            LocalizationSourceName = DatkConsts.LocalizationSourceName;
        }
    }
}