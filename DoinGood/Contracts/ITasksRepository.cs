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

        public List<Tasks> TasksList();

        public Tasks TaskComplete(Tasks task, int taskerValue, Fund taskerFund, int user);

    }
}
