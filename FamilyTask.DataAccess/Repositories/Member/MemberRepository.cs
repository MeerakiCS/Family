using AutoMapper;
using FamilyTask.Infrastructure.Models.Member;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FamilyTask.DataAccess.Repositories.Member
{

    public class MemberRepository : Repository<Data.Entities.Member>, IMemberRepository
    {
        private readonly IMapper _mapper;
        public MemberRepository(ApplicationDbContext dbcontext, IMapper mapper) : base(dbcontext)
        {
            _mapper = mapper;
        }
        void IRepository<Data.Entities.Member>.Add(Data.Entities.Member tEntity)
        {
            throw new NotImplementedException();
        }

        bool IMemberRepository.AddMember(Data.Entities.Member member)
        {
            try
            {
                member.CreatedDate = DateTime.Now;
                Add(member);
                return true;
            }
            catch(Exception )
            {
                return false;
            }
           
        }

        void IMemberRepository.UpdateMember(int id)
        {
            var member = GetById(id);

            Update(member);
        }

        IEnumerable<Data.Entities.Member> IMemberRepository.GetMembers()
        {
            return GetAll().OrderByDescending(x=>x.Id);
        }

        void IRepository<Data.Entities.Member>.AddRange(IEnumerable<Data.Entities.Member> tEntity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Data.Entities.Member> IRepository<Data.Entities.Member>.GetAll()
        {
            throw new NotImplementedException();
        }

        Data.Entities.Member IRepository<Data.Entities.Member>.GetById(int id)
        {
            throw new NotImplementedException();
        }

        void IRepository<Data.Entities.Member>.Remove(Data.Entities.Member tEntity)
        {
            throw new NotImplementedException();
        }
    }
}
