using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xolartek.Web.Controllers
{
    public class HomeController : Controller
    {
        protected static int seed = 0;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAttribs(int low, int high)
        {
            return Json(GetRandoms(low, high), JsonRequestBehavior.AllowGet);
        }

        private Dictionary<string, int> GetRandoms(int lowNumber, int highNumber)
        {
            Dictionary<string, int> sequence = new Dictionary<string, int>();
            int numberOfItems = 6;
            for (int i = 0; i < numberOfItems; i++)
            {
                Random rnd = new Random(seed++);
                sequence.Add(((Attribs)i).ToString(), rnd.Next(lowNumber, highNumber + 1));
            }
            return sequence;
        }
    }
    public enum Attribs
    {
        Agility, Durability, Intelligence, Speed, Stamina, Strength
    }
}