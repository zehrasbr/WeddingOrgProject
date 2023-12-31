﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=UNKNOWN\\SQLEXPRESS;database=WeddingDb;integrated security=true");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Info> Infos { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Rezervation> Rezervations { get; set; }
        public DbSet<RezervePlace> RezervePlaces { get; set; }
        public DbSet<OpenPlace> OpenPlaces { get; set; }
        public DbSet<PlacesDetail> PlacesDetail { get; set; }
        public DbSet<PlacesDetail2> PlacesDetail2 { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Comment> Comments { get; set; }

    }
}
