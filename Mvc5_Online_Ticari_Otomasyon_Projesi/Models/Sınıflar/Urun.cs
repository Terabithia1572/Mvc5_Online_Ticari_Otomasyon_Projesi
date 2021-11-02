using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string UrunAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(70)]
        public string Marka { get; set; }
        public short Stok { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public bool Durum { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string UrunGorsel { get; set; }
        public Kategori Kategori { get; set; }

        public SatisHareket SatisHareket { get; set; }
    }
}