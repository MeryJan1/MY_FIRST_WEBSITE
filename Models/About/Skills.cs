using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.About
{
    public class Skills
    {

        [Key]
        public int Id { get; set; }

        [DisplayName("Yetenekler")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Skill { get; set; }

        [DisplayName("Yetenek Yüzdesi")]
        public int Percentage { get; set; }


    }
}