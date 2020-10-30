using FamilyTask.Infrastructure.Models.Task;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace FamilyTask.DataAccess.Repositories.Task
{
    public class TaskRepository : Repository<Data.Entities.Task>, ITaskRepository
    {
        protected  new readonly ApplicationDbContext _dbContext;
        public TaskRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }

        bool ITaskRepository.AddTask(Data.Entities.Task tEntity)
        {
            try
            {
                tEntity.CreatedDate = DateTime.Now;
                Add(tEntity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        void ITaskRepository.UpdateTask(int id)
        {
            var task = GetById(id);

            Update(task);
        }

        Data.Entities.Task ITaskRepository.GetTaskById(int id)
        {
            return GetById(id);
        }

        void ITaskRepository.CompleteTask(int id)
        {
            var task = GetById(id);

            task.IsComplete = true;

            Update(task);
        }

        void ITaskRepository.AssignTask(int taskId, int memberId)
        {
            var task = GetById(taskId);

            if (task != null)
            {
                var member = _dbContext.Member.Where(x => x.Id == memberId).FirstOrDefault();
                task.AssignedMember = member;
                Update(task);
            }
        }

        IEnumerable<Data.Entities.Task> ITaskRepository.GetAllTasks()
        {
            return GetAll().OrderByDescending(x => x.Id);
        }

        void IRepository<Data.Entities.Task>.Add(Data.Entities.Task tEntity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Data.Entities.Task>.AddRange(IEnumerable<Data.Entities.Task> tEntity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Data.Entities.Task> IRepository<Data.Entities.Task>.GetAll()
        {
            throw new NotImplementedException();
        }

        Data.Entities.Task IRepository<Data.Entities.Task>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Data.Entities.Task>.Remove(Data.Entities.Task tEntity)
        {
            throw new NotImplementedException();
        }
    }
}
