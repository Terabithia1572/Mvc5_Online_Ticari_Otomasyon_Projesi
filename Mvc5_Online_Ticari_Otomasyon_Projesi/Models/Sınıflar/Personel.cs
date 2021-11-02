using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string PersonelGorsel { get; set; }

        public SatisHareket SatisHareket { get; set; }
        public Departman Departman { get; set; }
    }
}