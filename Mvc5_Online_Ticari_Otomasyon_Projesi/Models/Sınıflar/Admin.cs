using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string Yetki { get; set; }

    }
}