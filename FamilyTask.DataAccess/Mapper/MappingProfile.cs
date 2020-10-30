using AutoMapper;
using FamilyTask.DataAccess.Data.Entities;
using FamilyTask.Infrastructure.Models.Member;
using FamilyTask.Infrastructure.Models.Task;

namespace FamilyTask.DataAccess.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            //CreateMap<EmployeeDocuments, EmployeeDocumentModel>()
            //    .ForMember(dest => dest.DocumentId, opt => opt.MapFrom(src => src.Document.Id))
            //    .ForMember(dest => dest.DocumentName, opt => opt.MapFrom(src => src.Document.DocumentName))
            //    .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id))
            //    .ForMember(dest => dest.EmployeeName, opt => opt.MapFrom(src => src.User.FirstName + " " + src.User.LastName));

            CreateMap<MemberModel,Member>();
            CreateMap<Member, MemberModel>();
            CreateMap<TaskModel, Task>();
        }
    }
}
