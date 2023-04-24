namespace Dev.Fluent.API.Application.DTOs
{
    public class CustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Age { get; set; }
        public int Phone { get; set; }
        public AddressDto? Address { get; set; }
    }
}
