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
            builder.Entity<Fund>().HasData(
                new Fund { FundId = 1, FundName = "Inspired Fund", CurrentFunds = 0, NumberOfDonations = 0, Mission = "TBD" },
                new Fund { FundId = 2, FundName = "American Humane", CurrentFunds = 0, NumberOfDonations = 0, Mission = "To ensure the safety, welfare and well-being of animals; to serve in promoting and nurturing the bonds between animals and humans." },
                new Fund { FundId = 3, FundName = "American Red Cross", CurrentFunds = 0, NumberOfDonations = 0, Mission = "Prevents and alleviates human suffering in the face of emergencies by mobilizing the power of volunteers and the generosity of donors." },
                new Fund { FundId = 4, FundName = "Astraea Lesbian Foundation for Justice", CurrentFunds = 0, NumberOfDonations = 0, Mission = "Funds LGBTQI activism globally, serving as a feminist social justice hub and working side-by-side with grantee and donor partners to achieve rural, economic, social and gender justice worldwide." },
                new Fund { FundId = 5, FundName = "Cancer Research Institute", CurrentFunds = 0, NumberOfDonations = 0, Mission = "To save more lives by fueling the discovery and development of powerful immunotherapies for all types of cancer." },
                new Fund { FundId = 6, FundName = "Equal Justice Initiative", CurrentFunds = 0, NumberOfDonations = 0, Mission = "To end mass incarceration & excessive punishment in the U.S.; to challenge racial & economic injustice; and to protect basic human rights for the most vulnerable people in American society." },
                new Fund { FundId = 7, FundName = "Feeding America", CurrentFunds = 0, NumberOfDonations = 0, Mission = "To feed America's hungry through a nationwide network of food banks and engage our country in the fight to end hunger." },
                new Fund { FundId = 8, FundName = "Homes For Our Troops", CurrentFunds = 0, NumberOfDonations = 0, Mission = "To build and donate specially adapted custom homes nationwide for the most severely injured post-9/11 veterans, to enable them to rebuild their lives." },
                new Fund { FundId = 9, FundName = "National Wildlife Federation", CurrentFunds = 0, NumberOfDonations = 0, Mission = "To unite all Americans to ensure wildlife thrives in a rapidly changing world." },
                new Fund { FundId = 10, FundName = "Scholarship America", CurrentFunds = 0, NumberOfDonations = 0, Mission = "To mobilize America through scholarships and educational support to make post-secondary education possible for all students." }
                );
        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Catalyst> Catalysts { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
        public DbSet<Deed> Deeds { get; set; }
        public DbSet<Donate> Donations { get; set; }
        public DbSet<Fund> Fund { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
    }
}
