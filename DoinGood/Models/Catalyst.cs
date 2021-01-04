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
        public int CatalystId;

        [ForeignKey("IdentityUser")]
        public int IdentityUser;

        [ForeignKey("Address")]
        public int AddressId;

        public string FirstName;

        public string LastName;

        public int DeedCount;

        public int TastCount;

        public int DonateCount;

        public int TotalContribution;

        public string EmailAddress;

        public string Image;
    }
}
