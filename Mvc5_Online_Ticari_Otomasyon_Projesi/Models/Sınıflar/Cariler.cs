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
        [StringLength(50,ErrorMessage ="En Fazla 50 Karakter Girebilirsiniz..")]
        public string CariAd { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required(ErrorMessage ="Bu Alanı Boş geçemezsiniz..")]
        public string CariSoyad { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(13)]
        public string CariSehir { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string CariMail { get; set; }

        public bool Durum { get; set; }
        public ICollection<SatisHareket> SatisHarekets { get; set; }
    }
}