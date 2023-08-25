using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Contact
{
    public class Messages
    {
        
                [Key]
                public int Id { get; set; }

                [DisplayName("İsim")]
                [StringLength(128, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
                public string Name { get; set; }

                [DisplayName("Mail Adresi")]
                [StringLength(64, ErrorMessage = "Bu alan 64 karakterden fazla olamaz.")]
                public string Mail { get; set; }

                [DisplayName("Konu")]
                [StringLength(86, ErrorMessage = "Bu alan 86 karakterden fazla olamaz.")]
                public string Subject { get; set; }

                [DisplayName("Telefon Numarası")]
                public double PhoneNumber { get; set; }

                [DisplayName("Mesaj")]
                [StringLength(216, ErrorMessage = "Bu alan 216 karakterden fazla olamaz.")]
                public string Message { get; set; }

        
    }
}