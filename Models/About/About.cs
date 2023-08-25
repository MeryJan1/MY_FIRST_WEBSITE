using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace ProjeSon.Models.About
{
    public class about
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Hakkında Kısmı")]
        [StringLength(624, ErrorMessage = "Bu alan 624 karakterden fazla olamaz.")]
        public string AboutMe { get; set; }

    }
   



}
