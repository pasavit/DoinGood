using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Challenge
    {
        [Key]
        public int ChallengeId { get; set; }

        [ForeignKey("ChallengeCatalyst")]
        public int? ChallengeCatalystId { get; set; }
        public Catalyst ChallengeCatalyst { get; set; }

        [ForeignKey("DeedCatalyst")]
        public int? DeedCatalystId { get; set; }
        public Catalyst DeedCatalyst { get; set; }

        [ForeignKey("DeservingCause")]
        public int DeservingCauseId { get; set; }
        public DeservingCause DeservingCause { get; set; }

        public string Impact { get; set; }

        public int DonateAmount { get; set; }

        public int MaxAmount { get; set; }

        public int ChallengeCount { get; set; }
    }
}
