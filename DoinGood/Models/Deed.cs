using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Deed
    {
        [Key]
        public int DeedId { get; set; }

        [ForeignKey("Catalyst")]
        public int CatalystId { get; set; }
        public Catalyst Catalyst { get; set; }

        [ForeignKey("Fund")]
        public int FundId { get; set; }
        public Fund Fund { get; set; }

        public string Beneficence { get; set; }

        public string Impact { get; set; }

        public int DonateAmount { get; set; }

        public int MaxAmount { get; set; }

        public int InspireCount { get; set; }

        public int ChallengeCount { get; set; }
    }
}
