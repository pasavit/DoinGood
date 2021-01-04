using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class DeservingCause
    {
        [Key]
        public int DerservingCauseId { get; set; }

        public int CurrentFunds { get; set; }

        public int NumberOfDonations { get; set; }
    }
}
