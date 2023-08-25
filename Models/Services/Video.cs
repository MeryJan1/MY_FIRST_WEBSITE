using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Services
{
    public class Video
    {
        [Key] 
        public int Id { get; set; }

        [DisplayName("Video bağlantı linki")]
        public string VideoLink { get; set; }

        [DisplayName("Video resim konumu")]
        public string İmagePath { get; set; }



    }
}