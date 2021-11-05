using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Controllers
{
    public class KategoriController : Controller
    {
        // GET: Kategori
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.Kategoris.ToList();
            return View(degerler);
        }
    }
}