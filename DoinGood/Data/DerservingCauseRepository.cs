using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class DeservingCauseRepository : RepositoryBase<DeservingCause>, IDeservingCauseRepository
    {
        public DeservingCauseRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
