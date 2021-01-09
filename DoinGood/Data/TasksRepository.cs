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
        public Tasks GetTasksDetails(int id) => FindByCondition(t => t.TaskId == id).Include(e => e.Fund).Include(e => e.PosterCatalyst).Include(e => e.TaskerCatalyst).Include(e => e.PosterCatalyst.Address).FirstOrDefault();

        public List<Tasks> TasksList()
        {
            var tasksList = FindAll().Include(e => e.Fund).Include(e => e.PosterCatalyst).Include(e => e.PosterCatalyst.Address).ToList();
            return tasksList;
        }

        public Tasks PosterComplete(Tasks task, int posterValue, int taskerValue)
        {
            task.PosterComplete = true;
            if(task.PosterComplete && task.TaskerComplete == true)
            {
                task.PosterCatalyst.AccountBalance += task.Value;
                task.Fund.CurrentFunds += posterValue;
                task.TaskerFund.CurrentFunds = +taskerValue;
            }
            return task;
        }
        public Tasks TaskerComplete(Tasks task, int posterValue, int taskerValue)
        {
            task.TaskerComplete = true;
            if(task.PosterComplete && task.TaskerComplete == true)
            {
                task.PosterCatalyst.AccountBalance += task.Value;
                task.Fund.CurrentFunds += posterValue;
                task.TaskerFund.CurrentFunds += taskerValue;
            }
            return task;
        }
    }
}
