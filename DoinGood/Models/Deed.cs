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
        public int DeedId;

        [ForeignKey("Catalyst")]
        public int CatalystId;

        [ForeignKey("DeservingCause")]
        public int DeservingCauseId;

        public string Beneficence;

        public string Impact;

        public int DonateAmount;

        public int MaxAmount;

        public int InspireCount;

        public int ChallengeCount;
    }
}
