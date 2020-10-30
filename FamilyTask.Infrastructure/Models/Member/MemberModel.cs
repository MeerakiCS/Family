using FamilyTask.Infrastructure.Models.Task;
using System;
using System.Collections.Generic;
using System.Text;

namespace FamilyTask.Infrastructure.Models.Member
{
    public class MemberModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Roles { get; set; }
        public string Avatar { get; set; }
        public IEnumerable<TaskModel> Tasks { get; set; }
    }
}
