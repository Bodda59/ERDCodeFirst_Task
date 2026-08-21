namespace ERDCodeFirst.Domains
{
    public class Employees
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       public int? ManagerId { get; set; }
       public Employees? Manager { get; set; }
    }
}
