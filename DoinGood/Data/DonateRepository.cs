using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class DonateRepository : RepositoryBase<Donate>, IDonateRepository
    {
        public DonateRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
        public Donate GetDonateDetails(int id) => FindByCondition(d => d.DonationId == id).FirstOrDefault();
    }
}
