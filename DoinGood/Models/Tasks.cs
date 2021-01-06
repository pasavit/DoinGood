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

        [ForeignKey("PosterCatalyst")]
        public int? PosterCatalystId { get; set; }
        public Catalyst PosterCatalyst { get; set; }

        [ForeignKey("TaskerCatalyst")]
        public int? TaskerCatalystId { get; set; }
        public Catalyst TaskerCatalyst { get; set; }

        [ForeignKey("DeservingCause")]
        public int DerservingCauseId { get; set; }
        public DeservingCause DeservingCause { get; set; }

        public string TaskTitle { get; set; }

        public string TaskDescription { get; set; }

        public int Value { get; set; }

        public string Image { get; set; } 
    }
}
