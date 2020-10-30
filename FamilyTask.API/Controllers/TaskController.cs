using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FamilyTask.DataAccess.Repositories.Member;
using FamilyTask.DataAccess.Repositories.Task;
using FamilyTask.Infrastructure.Models.Member;
using FamilyTask.Infrastructure.Models.Task;
using Microsoft.AspNetCore.Mvc;


namespace FamilyTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        internal readonly ITaskRepository _task;
        private readonly IMapper _mapper;
        public TaskController(ITaskRepository task, IMapper mapper)
        {
            _task = task;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public DataAccess.Data.Entities.Task Get(int id)
        {
            return _task.GetTaskById(id);
        }

        [HttpGet]
        [Route("GetTasks")]
        public IEnumerable<DataAccess.Data.Entities.Task> Get()
        {
            return _task.GetAllTasks();
        }

        [HttpPost("AddTask")]
        public bool Post([FromBody] TaskModel task)
        {
           return  _task.AddTask(_mapper.Map<DataAccess.Data.Entities.Task>(task));
        }

        [HttpPut("UpdateTask/{id}")]
        public void Put(int id)
        {
            _task.UpdateTask(id);
        }
        
        [HttpPut("CompleteTask/{id}")]
        public void CompleteTask(int id)
        {
            _task.CompleteTask(id);
        } 
        
        [HttpPut("AssignTask/{taskId}/{memberId}")]
        public void AssignTask(int taskId,int memberId)
        {
            _task.AssignTask(taskId, memberId);
        }
    }
}
