using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using AutoMapper;
using FamilyTask.DataAccess.Data.Entities;
using FamilyTask.DataAccess.Repositories;
using FamilyTask.DataAccess.Repositories.Member;
using FamilyTask.DataAccess.Repositories.Task;
using FamilyTask.Infrastructure.Models.Member;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FamilyTask.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MemberController : ControllerBase
    {
        internal readonly IMemberRepository _member;
        private readonly IMapper _mapper;
        public MemberController(IMemberRepository member, IMapper mapper)
        {
            _member = member;
            _mapper = mapper;
        }
        // GET: api/<MemberController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpGet]
        [Route("getMembers")]
        public IEnumerable<MemberModel> GetMembers()
        {
            var members = _member.GetMembers();
            return _mapper.Map<IEnumerable<MemberModel>>(members);
        }

        [HttpPost]
        [Route("addMember")]
        public bool Post([FromBody] MemberModel member)
        {
            //_member.AddMember(member);
            return _member.AddMember(_mapper.Map<Member>(member));
        }

        [HttpPut("UpdateMember/{id}")]
        public void Put(int id)
        {
            _member.UpdateMember(id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
