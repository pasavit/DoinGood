using DoinGood.Contracts;
using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace DoinGood.Data
{
    public class DeedRepository : RepositoryBase<Deed>, IDeedRepository
    {
        public DeedRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Deed GetDeedDetails(int id) => FindByCondition(d => d.DeedId == id).Include(e => e.Fund).Include(e=> e.Catalyst).FirstOrDefault();

        public List<Deed> DeedList()
        {
            var deedList = FindAll().Include(e => e.Fund).Include(e => e.Catalyst).ToList();
            return deedList;
        }

        public void Inspired(Deed deed)
        {
            deed.InspireCount++;
            Update(deed);
        }
    }
}
