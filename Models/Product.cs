namespace ProductsAPI.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public decimal Weight { get; set; }
        public int WarrantyYears { get; set; }
        public string BatteryType { get; set; }
        public string BatteryLife { get; set; }

        public string Type { get; set; }
    }
}
