﻿using System;
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

        [ForeignKey("Fund")]
        public int FundId { get; set; }
        public Fund Fund { get; set; }

        public string TaskTitle { get; set; }

        public string TaskDescription { get; set; }

        public int Value { get; set; }

        public string Image { get; set; }

        public bool PosterComplete { get; set; } = false;

        public bool TaskerComplete { get; set; } = false;

        public int PosterValue { get; set; } //May  not need

        public int TaskerValue { get; set; }

        [ForeignKey("TaskerFund")]
        public int? TaskerFundId { get; set; }
        public Fund TaskerFund { get; set; }
    }
}
