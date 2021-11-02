using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }
    }
}