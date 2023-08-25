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

        [DisplayName("Icon_1")]
        public string Icon1URL { get; set; }
        [DisplayName("Servis_1")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Title1 { get; set; }
        [DisplayName("Servis İçeriği_1")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String11 { get; set; }
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String12 { get; set; }

        [DisplayName("Icon_2")]
        public string Icon2URL { get; set; }
        [DisplayName("Servis_2")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Title2 { get; set; }
        [DisplayName("Servis İçeriği_2")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String21 { get; set; }
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String22 { get; set; }

        [DisplayName("Icon_3")]
        public string Icon3URL { get; set; }
        [DisplayName("Servis_3")]
        public string Title3 { get; set; }
        [DisplayName("Servis İçeriği_3")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String31 { get; set; }
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String32 { get; set; }

        [DisplayName("Icon_4")]
        public string Icon4URL { get; set; }
        [DisplayName("Servis_4")]
        public string Title4 { get; set; }
        [DisplayName("Servis İçeriği_4")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String41 { get; set; }
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string String42 { get; set; }

    }
    public class Video
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Video bağlantı linki")]
        public string  VideoLink { get; set; }

        [DisplayName("Video resim konumu")]
        public string İmagePath { get; set; }



    }
}