using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Faturalar
    {
        [Key]
        public int FaturaID { get; set; }
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string FaturaSeriNo { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string FaturaSiraNo { get; set; }
        public DateTime Tarih { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string VergiDairesi { get; set; }
        public DateTime Saat { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string TeslimEden { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string TeslimAlan { get; set; }
        public ICollection<FaturaKalem> FaturaKalems { get; set; }

    }
}