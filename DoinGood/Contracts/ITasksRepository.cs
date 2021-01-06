using DoinGood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Contracts
{
    public interface ITasksRepository : IRepositoryBase<Tasks>
    {
        Tasks GetTasksDetails(int id);
    }
}
