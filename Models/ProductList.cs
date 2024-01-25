namespace ProvaPub.Models
{
	public class ProductList 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
        public List<Product> Products { get; set; }
        public ProductList(int id, string name, int totalCount, bool hasNext) 
        {
            Id = id;
            Name = name;
            TotalCount = totalCount;
            HasNext = hasNext;
            Products = new List<Product>();
        }
     
        public ProductList()
        {
            
        }


	}
}
