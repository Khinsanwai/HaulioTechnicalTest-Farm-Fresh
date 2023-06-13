namespace FarmProj.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public Decimal Qty { get; set; }
        public String Unit { get; set; }
        public int BrandID { get; set; }
        public DateTime CreatedDate { get; set; }
        public String CreatedBy { get; set; }
    }
}
