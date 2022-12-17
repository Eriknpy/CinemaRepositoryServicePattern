namespace RepositoryServicePattern.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Profit
        {
            get
            {
                return (SalePrice * Quantity) - (UnitPrice * Quantity);
            }
        }
    }
}
