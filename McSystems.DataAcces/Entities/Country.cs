namespace McSystems.DataAccess.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Customer> Customers { get; set; }
    }
}