
using AutoMapper;
using eCommerce.Core.DTO;
using eCommerce.Core.Entities;

namespace eCommerce.Core.Mappers;

    public class ApplicationUserMappingProfile:Profile
    {

    public ApplicationUserMappingProfile()
    {
      
       

        CreateMap<ApplicationUser,AuthenticationResponse>()
            .ForMember(dest=>dest.UserId,opt=>opt.MapFrom(dest=>dest.UserId))
            .ForMember(dest=>dest.Email,opt=>opt.MapFrom(dest=>dest.Email))
            .ForMember(dest=>dest.PersonName,opt=>opt.MapFrom(dest=>dest.PersonName))
            .ForMember(dest=>dest.Gender,opt=>opt.MapFrom(dest=>dest.Gender))
            .ForMember(dest=>dest.Success,opt=>opt.Ignore())
            .ForMember(dest=>dest.Token,opt=>opt.Ignore());
          
            
    }
}

