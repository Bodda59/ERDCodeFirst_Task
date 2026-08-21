namespace ERDCodeFirst.Domains
{
    public class Customers
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateOnly SignUpDate { get; set; }

        public ShippingAddress ShippingAddress { get; set; }
        public List<Orders> Orders { get; set; }    
        public List<Reviews> Reviews { get; set; }

    }
}
