namespace ProvaPub.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
        public BaseEntity()
        {

        }

        protected BaseEntity(int id, string name, int totalCount, bool hasNext)
        {
            this.Id = id;
            this.Name = name;
            this.TotalCount = totalCount;
            this.HasNext = hasNext;
        }
    }
}
