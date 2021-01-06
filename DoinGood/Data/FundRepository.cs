using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class FundRepository : RepositoryBase<Fund>, IFundRepository
    {
        public FundRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
