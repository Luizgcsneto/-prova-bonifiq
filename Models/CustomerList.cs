namespace ProvaPub.Models
{
	public class CustomerList 
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
        public List<Customer> Customers { get; set; }
        public CustomerList(int id, string name, int totalCount, bool hasNext) 
        {
            Id = id;
            Name = name;
            TotalCount = totalCount;
            HasNext = hasNext;
            Customers = new List<Customer>();
        }

        public CustomerList()
        {
            
        }

	}
}
