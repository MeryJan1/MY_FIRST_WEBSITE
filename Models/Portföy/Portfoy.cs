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
        [DisplayName("Dosya konumu")]
        public string PhotoPath11 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath12 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath13 { get; set; }

        [DisplayName("Konu Başlığı")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Name2 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath21 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath22 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath23 { get; set; }

        [DisplayName("Konu Başlığı")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Name3 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath31 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath32 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath33 { get; set; }

        [DisplayName("Konu Başlığı")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Name4 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath41 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath42 { get; set; }
        [DisplayName("Dosya konumu")]
        public string PhotoPath43 { get; set; }

    }
}