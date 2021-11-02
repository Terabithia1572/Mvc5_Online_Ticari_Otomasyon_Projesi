using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]

        public string KullaniciAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]

        public string Sifre { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string Yetki { get; set; }

    }
}