using FamilyTask.Infrastructure.Models.Task;
using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTask.DataAccess.Repositories.Task
{
    public interface ITaskRepository : IRepository<Data.Entities.Task>
    {
        bool AddTask(Data.Entities.Task tEntity);
        void UpdateTask(int id);
        void CompleteTask(int id);
        void  AssignTask(int taskId, int memberId);
        Data.Entities.Task GetTaskById(int id);
        IEnumerable<Data.Entities.Task> GetAllTasks();
    }
}
