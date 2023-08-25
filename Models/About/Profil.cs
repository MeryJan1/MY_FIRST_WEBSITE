using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.About
{
    public class Profil
    {
        
            [Key]
            public int Id { get; set; }

            [DisplayName("İsim")]
            [StringLength(128, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
            public string Name { get; set; }

            [DisplayName("Uyruk")]
            [StringLength(64, ErrorMessage = "Bu alan 64 karakterden fazla olamaz.")]
            public string Nationality { get; set; }

            [DisplayName("Mail Adresi")]
            [StringLength(64, ErrorMessage = "Bu alan 64 karakterden fazla olamaz.")]
            public string Email { get; set; }

            [DisplayName("Doğum Tarihi")]
            public DateTime DateOfBirth { get; set; }

            [DisplayName("Telefon Numarası (Başında Alan Numarası Olmadan Giriniz)")]
            public int Phone { get; set; }
        
    }
}