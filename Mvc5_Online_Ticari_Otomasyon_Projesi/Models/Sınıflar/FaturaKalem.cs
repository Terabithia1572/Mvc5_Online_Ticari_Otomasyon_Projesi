using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class FaturaKalem
    {
        [Key]
        public int FaturaKalemID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string Aciklama { get; set; }
        public int Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Tutar { get; set; }
        public Faturalar Faturalar { get; set; }

    }
}