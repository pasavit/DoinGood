using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Contracts
{
    public interface IRepositoryWrapper
    {
        IAddressRepository Address { get; }
        ICatalystRepository Catalyst { get; }
        IChallengeRepository Challenge { get; }
        IDeedRepository Deed { get; }
        IDonateRepository Donate { get; }
        IFundRepository Fund { get; }
        ITasksRepository Tasks { get; }
        void Save();
    }
}
