using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Contracts
{
    public interface IDonateRepository : IRepositoryBase<Donate>
    {
        Donate GetDonateDetails(int id);
        public List<Donate> DonateList();
        public Donate BuyDonation(Donate donate);

    }
}
