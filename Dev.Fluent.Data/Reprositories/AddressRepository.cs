using AutoMapper;
using Dev.Fluent.Common.Interfaces;
using Dev.Fluent.Data.Context;
using Dev.Fluent.Domain.Models;

namespace Dev.Fluent.Data.Reprositories
{
    public class AddressRepository : IRepositoryBase<Address>
    {
        protected readonly IMapper _mapper;
        protected readonly FluentApiDbContext _context;

        #region Repository constructor
        public AddressRepository(IMapper mapper, FluentApiDbContext context) {
            _mapper = mapper;
            _context = context;
        }
        #endregion

        public void CreateOrUpdate(Address entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
