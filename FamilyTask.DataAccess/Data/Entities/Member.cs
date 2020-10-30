using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FamilyTask.DataAccess.Data.Entities
{
    [Table("Member")]
    public class Member : BaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Roles { get; set; }
        public string Avatar { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
