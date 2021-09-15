using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B403Blog.Controllers
{
    using Models;
    public class KategoriController : Controller
    {
        B403BlogContext context = new B403BlogContext();

        // GET: Kategori
        public ActionResult Index(int id)
        {
            return View(id);
        }

        public PartialViewResult KategoriWidget()
        {
            return PartialView(context.Kategoris.ToList());
        }

        public ActionResult MakaleListele(int id) {
            var data = context.Makales.Where(x => x.KategoriId == id).ToList();
            return View("MakaleListeleWidget",data);
        }
        
    }
}