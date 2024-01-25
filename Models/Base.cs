namespace ProvaPub.Models
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalCount { get; set; }
        public bool HasNext { get; set; }
        public Base()
        {

        }

        protected Base(int id, string name, int totalCount, bool hasNext)
        {
            Id = id;
            Name = name;
            TotalCount = totalCount;
            HasNext = hasNext;
        }
    }
}
