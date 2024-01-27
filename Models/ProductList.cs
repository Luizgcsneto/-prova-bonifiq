namespace ProvaPub.Models
{
	public class ProductList : BaseEntity
    {
        public List<Product> Products { get; set; }
        public ProductList(int id, string name, int totalCount, bool hasNext) 
        {
            this.Id = id;
            this.Name = name;
            this.TotalCount = totalCount;
            this.HasNext = hasNext;
            this.Products = new List<Product>();
        }
     
        public ProductList()
        {
            
        }


	}
}
