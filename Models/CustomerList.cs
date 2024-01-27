namespace ProvaPub.Models
{
	public class CustomerList : BaseEntity
	{
        public List<Customer> Customers { get; set; }
        public CustomerList(int id, string name, int totalCount, bool hasNext) 
        {
            this.Id = id;
            this.Name = name;
            this.TotalCount = totalCount;
            this.HasNext = hasNext;
            this.Customers = new List<Customer>();
        }

        public CustomerList()
        {
            
        }

	}
}
