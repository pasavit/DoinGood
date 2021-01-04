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
        public int ChallengeId;

        [ForeignKey("Catalyst")]
        public int CatalystId;

        [ForeignKey("Catalyst")]
        public int DeedCatalystId;

        [ForeignKey("DeservingCause")]
        public int DeservingCauseId;

        public string Impact;

        public int DonateAmount;

        public int MaxAmount;

        public int ChallengeCount;
    }
}
