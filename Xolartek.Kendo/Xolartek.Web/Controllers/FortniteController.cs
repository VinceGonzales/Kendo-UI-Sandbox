using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Collections.Generic;
using System.Web.Mvc;
using Xolartek.Core.Fortnite;
using Xolartek.ORM;
using Xolartek.Web.Models;

namespace Xolartek.Web.Controllers
{
    public class FortniteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadHeroesList([DataSourceRequest] DataSourceRequest request)
        {
            Repository repo = new Repository(new XolarDatabase());
            List<Hero> result = repo.GetHeroes();
            return Json(result.ToDataSourceResult(request));
        }
    }
}