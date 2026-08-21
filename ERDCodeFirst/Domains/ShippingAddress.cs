namespace ERDCodeFirst.Domains
{
    public class ShippingAddress
    {
        public int CustomerId { get; set; }
        public Customers Customers { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }

       
    }
}
