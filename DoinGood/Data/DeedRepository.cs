using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class DeedRepository : RepositoryBase<Deed>, IDeedRepository
    {
        public DeedRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
