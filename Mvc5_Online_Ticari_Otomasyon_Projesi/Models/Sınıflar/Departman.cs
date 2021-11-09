using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi.Models.Sınıflar
{
    public class Departman
    {
        [Key]
        public int DepartmanID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string DepartmanAd { get; set; }
        // bir personelin birden fazla departmanı olabilir 
        //o yüzden biz ICollection<Personel> dedik
        public bool Durum { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}