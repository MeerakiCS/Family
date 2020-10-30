using FamilyTask.Infrastructure.Models.Member;
using System;
using System.Collections.Generic;
using System.Text;
using FamilyTask.DataAccess.Data.Entities;

namespace FamilyTask.DataAccess.Repositories
{
    public interface IMemberRepository : IRepository<Data.Entities.Member>
    {
        bool AddMember(Data.Entities.Member member);
        void UpdateMember(int id);
        IEnumerable<Data.Entities.Member> GetMembers();
    }
}
