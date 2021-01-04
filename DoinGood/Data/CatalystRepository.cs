﻿using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class CatalystRepository : RepositoryBase<Catalyst>, ICatalystRepository
    {
        public CatalystRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Catalyst GetCatalyst(string catalystUserId) => FindByCondition(c => c.IdentityUserId == catalystUserId).FirstOrDefault();

        public Catalyst GetCatalystDetails(int id) => FindByCondition(c => c.CatalystId == id).FirstOrDefault();
    }
}
