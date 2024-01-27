namespace ProvaPub.Models
{
	public class Order : BaseEntity
    {
       
        public decimal Value { get; set; }
		public int CustomerId { get; set; }
		public DateTime OrderDate { get; set; }
		public Customer Customer { get; set; }

        public Order(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.OrderDate = DateTime.Now;
        }
        public Order()
        {
            
        }
    }
}
