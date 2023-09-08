
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Portföy
{
    public class Portfoy
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Konu Başlığı")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Name1 { get; set; }
        [DisplayName("Resim Dosyasının Linki")]
        public string PhotoPath11 { get; set; }
        [DisplayName("Resim Dosyasının Linki")]
        public string PhotoPath12 { get; set; }
        [DisplayName("Resim Dosyasının Linki")]
        public string PhotoPath13 { get; set; }
        [DisplayName("Resim Dosyasının Linki")]
        public string PhotoPath14 { get; set; }
        [DisplayName("Resim Dosyasının Linki")]
        public string PhotoPath15 { get; set; }
        [DisplayName("Resim Dosyasının Linki")]
        public string PhotoPath16 { get; set; }



    }
}