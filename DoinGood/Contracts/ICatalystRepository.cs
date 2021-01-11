using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Contracts
{
    public interface ICatalystRepository : IRepositoryBase<Catalyst>
    {
        Catalyst GetCatalyst(string catalystUserId);

        Catalyst GetCatalystDetails(int id);

        Catalyst GeoCode(Catalyst catalyst);

        public void CreationFee(int id);

    }
}
