using Dev.Fluent.Common.Models;

namespace Dev.Fluent.Domain.Models
{
    public class Address: EntityBase
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
    }
}
