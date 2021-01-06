using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Catalyst
    {
        [Key]
        public int CatalystId { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DeedCount { get; set; }

        public int TaskCompletedCount { get; set; }

        public int DonationCount { get; set; }

        public int ChallengedCount { get; set; }

        public int TotalContribution { get; set; }

        public string EmailAddress { get; set; }

        public string Image { get; set; }
    }
}
