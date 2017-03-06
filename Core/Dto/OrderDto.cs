namespace Core.Dto
{
    public class OrderDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int CardNumber { get; set; }
        public int CardExpirationMonth { get; set; }
        public int CardExpirationYear { get; set; }
        public int CardSecurityCode { get; set; }
        public int ProductId { get; set; }
        public int Price { get; set; }
    }
}
