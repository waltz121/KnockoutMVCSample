namespace InventorySalesDomain
{
    public class ProductDomain
    {
        public int Id { get; set; }
        public int ProductTypeCode { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ReorderLevel { get; set; }
        public int ReorderQuantity { get; set; }
        public string OtherDetails { get; set; }
    }
}
