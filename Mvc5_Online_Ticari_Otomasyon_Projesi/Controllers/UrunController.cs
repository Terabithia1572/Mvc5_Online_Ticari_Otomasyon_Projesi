using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Uruns.ToList();
            return View(urunler);
        }
    }
}