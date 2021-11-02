﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string KategoriAd { get; set; }
        public ICollection<Urun> Uruns { get; set; }
    }
}