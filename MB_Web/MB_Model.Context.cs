﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MB_Web
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Mobile_TownEntities : DbContext
    {
        public Mobile_TownEntities()
            : base("name=Mobile_TownEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Artikli> Artiklis { get; set; }
        public virtual DbSet<Artikli_knjizeno> Artikli_knjizeno { get; set; }
        public virtual DbSet<Dug> Dugs { get; set; }
        public virtual DbSet<Korisnici> Korisnicis { get; set; }
        public virtual DbSet<mob_hover> mob_hover { get; set; }
        public virtual DbSet<mob_hover_knjizeno> mob_hover_knjizeno { get; set; }
        public virtual DbSet<Narudzbine> Narudzbines { get; set; }
        public virtual DbSet<Racuni> Racunis { get; set; }
        public virtual DbSet<Racuni_hover_mob> Racuni_hover_mob { get; set; }
        public virtual DbSet<Racuni_knjizeno> Racuni_knjizeno { get; set; }
        public virtual DbSet<Rezervacija> Rezervacijas { get; set; }
        public virtual DbSet<Servi> Servis { get; set; }
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<BuildVersion> BuildVersions { get; set; }
        public virtual DbSet<ErrorLog> ErrorLogs { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
    }
}
