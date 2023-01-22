namespace Aflevering1.Models
{
    public class Shoppinglist
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public Units Unit { get; set; }
        public ShopArea Area { get; set; }
    }
}
