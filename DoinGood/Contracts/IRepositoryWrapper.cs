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
        IDeservingCauseRepository DeservingCause { get; }
        IDonateRepository Donate { get; }
        IInspiredFundRepository InspiredFund { get; }
        ITasksRepository Tasks { get; }
        void Save();
    }
}
