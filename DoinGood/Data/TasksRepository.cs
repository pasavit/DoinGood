using DoinGood.Contracts;
using DoinGood.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoinGood.Data
{
    public class TasksRepository : RepositoryBase<Tasks>, ITasksRepository
    {
        public TasksRepository(ApplicationDbContext applicationDbContext):base(applicationDbContext)
        {
        }
        public Tasks GetTasksDetails(int id) => FindByCondition(t => t.TaskId == id).Include(e => e.Fund).Include(e => e.TaskerFund).Include(e => e.PosterCatalyst).Include(e => e.TaskerCatalyst).Include(e => e.PosterCatalyst.Address).FirstOrDefault();

        public List<Tasks> TasksList()
        {
            var tasksList = FindAll().Include(e => e.Fund).Include(e => e.PosterCatalyst).Include(e => e.PosterCatalyst.Address).ToList();
            return tasksList;
        }
        public Tasks TaskComplete(Tasks task, int taskerValue, Fund taskerFund, int user)
        {
            var taskInDb = GetTasksDetails(task.TaskId);
            if (user == taskInDb.PosterCatalystId)
            {
                taskInDb.PosterComplete = true;
            }
            else
            {
                taskInDb.TaskerComplete = true;
            }
            taskInDb.TaskerFund = taskerFund;
            var posterValue = taskInDb.Value - taskerValue;
            if (taskInDb.PosterComplete && taskInDb.TaskerComplete == true)
            {
                taskInDb.PosterCatalyst.AccountBalance += taskInDb.Value;
                taskInDb.Fund.CurrentFunds += posterValue;
                taskInDb.Fund.NumberOfDonations++;
                taskInDb.TaskerFund.CurrentFunds += taskerValue;
                if (taskerValue != 0)
                {
                    taskInDb.TaskerFund.NumberOfDonations++;
                }
            }
            Update(taskInDb);
            return taskInDb;
        }
        
    }
}
