using DoinGood.Contracts;
using DoinGood.Models;
using Microsoft.EntityFrameworkCore;
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
        public Donate GetDonateDetails(int id) => FindByCondition(d => d.DonationId == id).Include(e => e.Fund).Include(e => e.PosterCatalyst).Include(e => e.PosterCatalyst.Address).Include(e => e.DonorCatalyst).Include(e => e.DonorCatalyst.Address).FirstOrDefault();

        public List<Donate> DonateList()
        {
            var donateList = FindAll().Include(e => e.Fund).Include(e => e.PosterCatalyst).Include(e => e.PosterCatalyst.Address).ToList();
            return donateList;
        }

        public Donate BuyDonation(Donate donate)
        {
            donate.DonorCatalyst.AccountBalance += (donate.Value + 1);
            donate.Fund.CurrentFunds =+ donate.Value;
            donate.Fund.NumberOfDonations++;
            return donate;
        }
    }
}
