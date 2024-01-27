namespace ProvaPub.Models
{
	public class Customer : BaseCommunity
    {
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Orders = new List<Order>();
        }
        public Customer()
        {
            
        }
        public ICollection<Order> Orders { get; set; }
	}
}
