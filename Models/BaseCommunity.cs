namespace ProvaPub.Models
{
    public abstract class BaseCommunity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public BaseCommunity(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public BaseCommunity()
        {
            
        }
    }
}
