﻿using DoinGood.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Contracts
{
    public interface IFundRepository : IRepositoryBase<Fund>
    {
        Fund GetFund(int id);
        public SelectList FundList();
        public void InspiredFund();
    }
}
