using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FamilyTask.DataAccess.Data.Entities
{
    [Table("Task")]
    public class Task : BaseEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public bool IsComplete { get; set; }
        public Member AssignedMember { get; set; }
    }
}
