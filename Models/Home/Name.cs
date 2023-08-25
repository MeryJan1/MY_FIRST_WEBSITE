using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Home
{
    public class Name
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("İsim ")]
        [StringLength(32, ErrorMessage = "Bu alan 32 karakterden fazla olamaz.")]
        public string name { get; set; }

        [DisplayName("Soyisim")]
        [StringLength(32, ErrorMessage = "Bu alan 32 karakterden fazla olamaz.")]
        public string Surname { get; set; }
    }

}