using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Services
{
    public class ServicesInfo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Icon URL")]
        public string Icon1URL { get; set; }

        [DisplayName("Servis İsmi")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Title1 { get; set; }

        [DisplayName("Servis İçeriği")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String11 { get; set; }

        [DisplayName("Servis İçeriği")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String12 { get; set; }

        

    }
    
}