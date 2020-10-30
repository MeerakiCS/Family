using FamilyTask.Infrastructure.Models.Member;
using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTask.Infrastructure.Models.Task
{
    public class TaskModel
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public bool IsComplete { get; set; }
        public MemberModel AssignedMember { get; set; }
    }
}
