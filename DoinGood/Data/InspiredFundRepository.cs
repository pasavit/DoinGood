using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class InspiredFundRepository : RepositoryBase<InspiredFund>, IInspiredFundRepository
    {
        public InspiredFundRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
