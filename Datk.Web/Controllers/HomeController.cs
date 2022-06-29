using System.Web.Mvc;

namespace Datk.Web.Controllers
{
    public class HomeController : DatkControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}