using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        [ForeignKey("Catalyst")]
        public int PosterCatalystId { get; set; }

        [ForeignKey("Catalyst")]
        public int TaskerCatalystId { get; set; }

        [ForeignKey("DeservingCause")]
        public int DerservingCauseId { get; set; }

        public string TaskTitle { get; set; }

        public string TaskDescription { get; set; }

        public int Value { get; set; }

        public string Image { get; set; } 
    }
}
