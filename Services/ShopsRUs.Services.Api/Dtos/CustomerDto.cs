namespace ShopsRUs.Services.Api.Dtos
{
    public class CustomerDto
    {
        string Name { get; set; }
        public DateTime? RegisteredDate { get; set; }
        public bool IsAffiliete { get; set; }
        public bool IsEmployee { get; set; }

    }
}
