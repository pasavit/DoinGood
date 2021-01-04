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
        public int DerservingCauseId;

        public int CurrentFunds;

        public int NumberOfDonations;
    }
}
