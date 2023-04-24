using Dev.Fluent.Common.Models;

namespace Dev.Fluent.Domain.Models
{
    public class Customer: EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        public Address Address { get; set; }
    }
}
