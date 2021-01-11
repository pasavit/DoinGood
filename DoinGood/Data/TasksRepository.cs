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

        public Tasks PosterComplete(Tasks task, int taskerValue)
        {
            task.PosterComplete = true;
            var posterValue = task.Value - taskerValue;
            if(task.PosterComplete && task.TaskerComplete == true)
            {
                task.PosterCatalyst.AccountBalance += task.Value;
                task.Fund.CurrentFunds += posterValue;
                task.Fund.NumberOfDonations++;
                task.TaskerFund.CurrentFunds += taskerValue;
                if(taskerValue != 0)
                {
                    task.TaskerFund.NumberOfDonations++;
                }
            }
            return task;
        }
        public Tasks TaskerComplete(Tasks task, int taskerValue, Fund taskerFund)
        {
            var taskInDb = GetTasksDetails(task.TaskId);
            taskInDb.TaskerFund = taskerFund;
            taskInDb.TaskerComplete = true;
            var posterValue = taskInDb.Value - taskerValue;
            if (taskInDb.PosterComplete && taskInDb.TaskerComplete == true)
            {
                taskInDb.PosterCatalyst.AccountBalance += taskInDb.Value;
                taskInDb.Fund.CurrentFunds += posterValue;
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
