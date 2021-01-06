using System;
using System.Collections.Generic;
using System.Text;
using DoinGood.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DoinGood.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole{Name = "Benefactor",NormalizedName = "BENEFACTOR"},
                new IdentityRole{Name = "Admin",NormalizedName = "ADMIN"}
                );
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Catalyst> Catalysts { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Deed> Deeds { get; set; }
        public DbSet<DeservingCause> DeservingCauses { get; set; }
        public DbSet<Donate> Donations { get; set; }
        public DbSet<InspiredFund> InspiredFunds { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
