using AutoMapper;
using Dev.Fluent.API.Application.DTOs;
using Dev.Fluent.Domain.Models;

namespace Dev.Fluent.API.Application
{
    public class MappingProfile: Profile
    {
        #region Mapping constructor
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>();
            CreateMap<Address, AddressDto>();
        }
        #endregion
    }
}
