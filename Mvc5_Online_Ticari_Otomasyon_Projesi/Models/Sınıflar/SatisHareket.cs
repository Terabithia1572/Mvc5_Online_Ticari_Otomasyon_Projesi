using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class SatisHareket
    {
        [Key]
        public int SatisHareketID { get; set; }
        //ürün
        //cari
        //personel
        //+
        //--------------------
        //ilişkiler ürün cari personel
        public DateTime Tarih { get; set; }
        public int Adet { get; set; }
        public decimal Fiyat { get; set; }
        public decimal ToplamTutar { get; set; }

        public ICollection<Urun> Uruns { get; set; }
        public ICollection<Cariler> Carilers { get; set; }
        public ICollection<Personel> Personels { get; set; }

    }
}