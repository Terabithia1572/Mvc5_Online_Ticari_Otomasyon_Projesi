using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Personel
    {
        [Key]
        public int PersonelID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string PersonelAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string PersonelSoyad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(500)]
        public string PersonelGorsel { get; set; }

        public ICollection<SatisHareket> SatisHarekets { get; set; }

        public int DepartmanID { get; set; }
        public virtual Departman Departman { get; set; }
    }
}