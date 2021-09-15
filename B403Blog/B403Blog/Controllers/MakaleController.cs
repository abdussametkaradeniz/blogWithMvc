using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B403Blog.Controllers
{
    using Models;
    public class MakaleController : Controller
    {

        B403BlogContext context = new B403BlogContext();
        // GET: Makale
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detay(int id)
        {
            var data = context.Makales.FirstOrDefault(x => x.MakaleId == id);
            return View(data);
        }
    }
}