using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Contracts
{
    public interface IChallengeRepository : IRepositoryBase<Challenge>
    {
        public Deed DeedChallengeModdifier(Deed deed, Catalyst catalyst);
    }
}
