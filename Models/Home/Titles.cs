﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.Home
{
    public class Titles
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Ünvanlar")]
        [StringLength(36, ErrorMessage = "Bu alan 36 karakterden fazla olamaz.")]
        public string Skill { get; set; }
    }

   
}