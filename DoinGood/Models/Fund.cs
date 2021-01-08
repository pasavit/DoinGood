using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Fund
    {
        [Key]
        public int FundId { get; set; }

        public string FundName { get; set; }

        public int CurrentFunds { get; set; }

        public int NumberOfDonations { get; set; }

        public string Mission { get; set; }
    }
}
