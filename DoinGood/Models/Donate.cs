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
        public int DonationId;

        [ForeignKey("Address")]
        public int AddressId;

        [ForeignKey("Catalyst")]
        public int PosterCatalystId;

        [ForeignKey("Catalyst")]
        public int DonorCatalystId;

        [ForeignKey("DerservingCause")]
        public int DerservingCauseId;

        public string ItemName;

        public string ItemDescription;

        public int Value;

        public string Image;
    }
}
