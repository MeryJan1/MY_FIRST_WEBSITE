using ProjeSon.Models.About;
using ProjeSon.Models.Contact;
using ProjeSon.Models.Home;
using ProjeSon.Models.Navbar;
using ProjeSon.Models.Portföy;
using ProjeSon.Models.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjeSon.Models.DataContext
{
    public class PersonelSiteDB : DbContext
    {

        public PersonelSiteDB() : base("PersonelSiteDb")
        {

        }
        public DbSet<Skills> Skillsinfos{ get; set; }
        public DbSet<about> aboutinfos { get; set; }
        public DbSet<Profil> Profilinfos { get; set; }
        public DbSet<Information> Informationinfos { get; set; }
        public DbSet<Messages> Messagesinfos { get; set; }
        public DbSet<Titles> Titlesinfos { get; set; }
        public DbSet<Name> Nameinfos { get; set; }
        public DbSet<NavbarInfo> Navbarinfos { get ; set ; }
        public DbSet<Portfoy> Portfoyinfos { get; set; }
        public DbSet<ServicesInfo> Servicesinfos { get; set; }
        public DbSet<Video> Videoinfos { get; set; }

    }
}