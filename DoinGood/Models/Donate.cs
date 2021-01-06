using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Donate
    {
        [Key]
        public int DonationId { get; set; } 

        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }

        [ForeignKey("PosterCatalyst")]
        public int? PosterCatalystId { get; set; }
        public Catalyst PosterCatalyst { get; set; }

        [ForeignKey("DonorCatalyst")]
        public int? DonorCatalystId { get; set; }
        public Catalyst DonorCatalyst { get; set; }

        [ForeignKey("DerservingCause")]
        public int DerservingCauseId { get; set; }
        public DeservingCause DeservingCause { get; set; }

        public string ItemName { get; set; }

        public string ItemDescription { get; set; }

        public int Value { get; set; }

        public string Image { get; set; }
    }
}
