using Abp.Web.Mvc.Views;

namespace Datk.Web.Views
{
    public abstract class DatkWebViewPageBase : DatkWebViewPageBase<dynamic>
    {

    }

    public abstract class DatkWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected DatkWebViewPageBase()
        {
            LocalizationSourceName = DatkConsts.LocalizationSourceName;
        }
    }
}