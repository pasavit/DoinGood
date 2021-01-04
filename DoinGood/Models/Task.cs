using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Models
{
    public class Task
    {
        [Key]
        public int TaskId;

        [ForeignKey("Catalyst")]
        public int PosterCatalystId;

        [ForeignKey("Catalyst")]
        public int TaskerCatalystId;

        [ForeignKey("DeservingCause")]
        public int DerservingCauseId;

        public string TaskTitle;

        public string TaskDescription;

        public int Value;

        public string Image;
    }
}
