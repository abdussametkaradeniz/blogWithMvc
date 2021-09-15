using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B403Blog.Controllers
{
    using Models; //models klasorunu dahil ettik
    using App_Classes;
    public class HomeController : Controller
    {
        B403BlogContext context = new B403BlogContext();

        public ActionResult Index()
        {
            return View();
        }

       public ActionResult MakaleListele()
        {
            var data = context.Makales.ToList();
            return View("MakaleListeleWidget",data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public PartialViewResult PopulerMakalelerWidget()
        {
            //eklenme tarihine gore son eklenen 3 tanesini alip buraya listelesin.
            var model = context.Makales.OrderByDescending(x => x.EklenmeTarihi).Take(5).ToList();
            return PartialView(model);
        }
    }
}