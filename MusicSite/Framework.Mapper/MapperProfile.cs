using AutoMapper;
using Framework.Models.Entities;
using Framework.Models.Request;
using Framework.Utility.Dependency;

namespace Framework.Mapper
{
    public class MapperProfile : Profile, IProfile
    { 
        public MapperProfile() {
  
            //CreateMap<Employee, EmployeeDto>()
            //    .ForMember(d => d.EmployeeDetail, s => s.Ignore())
            //    .ForMember(d => d.EmployeeLogins, s => s.Ignore());
            //CreateMap<EmployeeDto, Employee>()
            //        .ForMember(d => d.EmployeeDetail, s => s.Ignore())
            //        .ForMember(d => d.EmployeeLogins, s => s.Ignore());

            CreateMap<Biz_Collect, CollectRequest>().ReverseMap();

            CreateMap<Biz_Singer, SingerRequest>().ReverseMap();

            CreateMap<Biz_Comment, CommentRequest>().ReverseMap();

            CreateMap<Biz_Consumer, ConsumerRequest>().ReverseMap();

            CreateMap<Biz_Song, SongRequest>().ReverseMap();

            CreateMap<Biz_List_Song, ListSongRequest>().ReverseMap(); 
        }
    }
}