using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class ChallengeRepository : RepositoryBase<Challenge>, IChallengeRepository
    {
        public ChallengeRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Deed DeedChallengeModdifier(Deed deed, Catalyst catalyst)
        {
            deed.ChallengeCount++;
            if (deed.ChallengeCount * deed.DonateAmount <= deed.MaxAmount)
            {
                catalyst.AccountBalance += deed.DonateAmount;
                deed.Fund.CurrentFunds += deed.DonateAmount;
            }
            return deed;
        }
    }
}
