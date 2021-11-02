using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Cariler
    {
        [Key]
        public int CariID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CariAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string CariSoyad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(13)]
        public string CariSehir { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string CariMail { get; set; }
        public SatisHareket SatisHareket { get; set; }
    }
}