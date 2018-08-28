using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Collections.Generic;
using System.Web.Mvc;
using Xolartek.Core.Fortnite;
using Xolartek.ORM;
using Xolartek.Web.Fortnite.Models;

namespace Xolartek.Web.Fortnite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadHeroesList([DataSourceRequest] DataSourceRequest request)
        {
            Repository repo = new Repository(new XolarDatabase());
            List<Hero> heroes = repo.GetHeroes();
            List<HeroVM> result = new List<HeroVM>();
            foreach (Hero hero in heroes)
            {
                HeroVM vm = new HeroVM();
                vm.Id = hero.Id;
                vm.Name = hero.Name;
                vm.Rarity = hero.Rarity.Description;
                vm.ImgUrl = hero.Picture.Source;
                vm.Stars = hero.Stars;
                vm.Level = hero.Level;
                vm.Description = hero.Description;
                result.Add(vm);
            }
            return Json(result.ToDataSourceResult(request));
        }
    }
}