using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Contracts
{
    public interface IDeedRepository : IRepositoryBase<Deed>
    {
        Deed GetDeedDetails(int id);

        public List<Deed> DeedList();

        public void Inspired(Deed deed);

        public Deed DirectDonate(Deed deed, Catalyst catalyst, int amount);

    }
}
