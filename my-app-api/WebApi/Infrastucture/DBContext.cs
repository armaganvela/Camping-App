﻿using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace WebApi.Models
{
    public class AppUsersDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppUsersDbContext()
            : base("CnnStr1", throwIfV1Schema: false)
        {
            this.Configuration.LazyLoadingEnabled = true;
        }

        public DbSet<Camp> Camps { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Talk> Talks { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Attachment> Attachments { get; set; }

        public static AppUsersDbContext Create()
        {
            return new AppUsersDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<AppUsersDbContext>(null);

            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Camp>()
            //  .HasOptional(s => s.City)
            //  .WithMany()
            //  .WillCascadeOnDelete(false);
        }
    }
}