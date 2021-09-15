using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B403Blog.Controllers
{
    using Models;
    public class EtiketController : Controller
    {
        // GET: Etiket
        B403BlogContext context = new B403BlogContext();
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult EtiketlerWidget()
        {
            return PartialView(context.Etikets.ToList());
        }
        public ActionResult MakaleListele(int id)
        {
            //any metodu icerde yaptigimiz kontrol var mi diye kontrol eder varsa true yoksa false dondurur
            var data = context.Makales.Where(x => x.Etikets.Any(y=>y.EtiketId==id)).ToList();
            return View("MakaleListeleWidget", data);
        }

    }
}