using AutoMapper;
using WorkShopApi.Model;

namespace WorkShopApi.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerRequest, CustomerModel>()
                .ForMember(destiny => destiny.FirstName, origin => origin.MapFrom(source => source.FirstName_Modified))
                .ForMember(destiny => destiny.Email, origin => origin.MapFrom(source => source.Email_Modified));
        }
    }
}
