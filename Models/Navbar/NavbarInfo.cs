using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Navbar
{
    public class NavbarInfo
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Logo")]
        public string Logo { get; set; }

        [DisplayName("Navbar 1. bölüm")]
        [StringLength(64, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
        public string section1 { get; set; }

        [DisplayName("Navbar 2. bölüm")]
        [StringLength(64, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
        public string section2 { get; set; }

        [DisplayName("Navbar 3. bölüm")]
        [StringLength(64, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
        public string section3 { get; set; }

        [DisplayName("Navbar 4. bölüm")]
        [StringLength(64, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
        public string section4 { get; set; }

        [DisplayName("Navbar 5. bölüm")]
        [StringLength(64, ErrorMessage = "Bu alan 128 karakterden fazla olamaz.")]
        public string section5 { get; set; }

        [DisplayName("Github linki")]
        public string Github { get; set; }

        [DisplayName("Linkedin linki")]
        public string Linkedin { get; set; }

        [DisplayName("Youtube linki")]
        public string Youtube { get; set; }

        [DisplayName("İnstagram linki")]
        public string İnstagram { get; set; }
    }
}