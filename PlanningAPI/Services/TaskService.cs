using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PlanningAPI.Models;
using PlanningAPI.PlanningAPIContext;

namespace PlanningAPI.Services
{
    public class TaskService
    {
        private PlanningAPIContext.PlanningAPIContext db = new PlanningAPIContext.PlanningAPIContext();

        public IEnumerable<Task> GetAllTasks()
        {
            
            return db.Tasks
                .Include("CreationAuthor")
                .Include("Executor")
                .ToList();

        }

        public Task GetTask(long id)
        {
            return db.Tasks
                .Include("CreationAuthor")
                .Include("Executor")
                .FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTask(Task task)
        {
            db.Entry(task).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
    }
}