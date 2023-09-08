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

        public string AboutMe { get; set; }

    }
   



}
