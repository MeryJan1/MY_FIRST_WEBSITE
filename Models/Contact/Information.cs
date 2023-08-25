using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Contact
{
    public class Information
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Mail Adresim")]
        [StringLength(50, ErrorMessage = "Bu alan 50 karakterden fazla olamaz.")]
        public string YourMail { get; set; }

        [DisplayName("Telefon Numaram")]
        public double PhoneNumber { get; set; }

        [DisplayName("Adresim")]
        [StringLength(128, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
        public string Address { get; set; }


    }
    
}