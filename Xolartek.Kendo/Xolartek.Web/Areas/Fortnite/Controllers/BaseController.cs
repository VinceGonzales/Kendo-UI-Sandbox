using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System.Collections.Generic;
using System.Web.Mvc;
using Xolartek.Core.Fortnite;
using Xolartek.ORM;
using Xolartek.Web.Fortnite.Models;

namespace Xolartek.Web.Fortnite.Controllers
{
    public class BaseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hero(int id)
        {
            HeroVM vm = new HeroVM();
            using (Repository repo = new Repository(new XolarDatabase()))
            {
                Xolartek.Core.Fortnite.Hero hero = repo.GetHero(id);
                vm.Id = hero.Id;
                vm.Name = hero.Name;
                vm.Rarity = hero.Rarity.Description;
                vm.ImgUrl = hero.Picture.Source;
                vm.Stars = hero.Stars;
                vm.Level = hero.Level;
                vm.Description = hero.Description;
            }
            return View(vm);
        }
        public ActionResult Schematics(int id = 0)
        {
            using (Repository repo = new Repository(new XolarDatabase()))
            {
                ViewData["WeaponTypes"] = repo.GetWeaponTypes();
                ViewData["weapontypeid"] = id;
                return View();
            }
        }
        public ActionResult LoadHeroesList([DataSourceRequest] DataSourceRequest request)
        {
            using (Repository repo = new Repository(new XolarDatabase()))
            {
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
        public ActionResult LoadSchematicList([DataSourceRequest] DataSourceRequest request, int id)
        {
            using (Repository repo = new Repository(new XolarDatabase()))
            {
                List<SchematicVM> result = new List<SchematicVM>();
                List<Schematic> schematics;
                if (id > 0)
                {
                    schematics = repo.GetSchematics(id);
                }
                else
                {
                    schematics = repo.GetSchematics();
                }
                foreach (Schematic sch in schematics)
                {
                    SchematicVM vm = new SchematicVM();
                    vm.id = sch.Id;
                    vm.name = sch.Name;
                    vm.imgurl = sch.Picture.Source;
                    vm.level = sch.Level;
                    vm.stars = sch.Stars;
                    vm.description = sch.Description;
                    vm.stat = new List<stat>();

                    List<TraitImpact> impacts = repo.GetTraitImpacts(sch.Id);
                    foreach (TraitImpact ti in impacts)
                    {
                        stat s = new stat();
                        s.name = ti.Trait.Description;
                        s.value = ti.Impact;
                        vm.stat.Add(s);
                    }

                    result.Add(vm);
                }
                return Json(result.ToDataSourceResult(request));
            }
        }
    }
}