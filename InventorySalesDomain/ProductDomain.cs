namespace InventorySalesDomain
{
    public class ProductDomain
    {
        public int Id { get; set; }
        public int Product_Type_Code { get; set; }
        public decimal Unit_Price { get; set; }
        public string Product_Name { get; set; }
        public string Product_Description { get; set; }
        public int Reorder_Level { get; set; }
        public int Reorder_Quantity { get; set; }
        public string Other_Details { get; set; }
    }
}
