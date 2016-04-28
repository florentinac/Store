
namespace StoreCore.Repository
{
    public class Product: IIndexable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Category { get; set; }
        public int Stock { get; set; }
    }
}
