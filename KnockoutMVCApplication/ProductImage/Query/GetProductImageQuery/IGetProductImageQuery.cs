using KnockoutMVCApplication.ProductImage.Model;

namespace KnockoutMVCApplication.ProductImage.Query.GetProductImageQuery
{
    public interface IGetProductImageQuery
    {
        ProductImageDetailModel ExecuteQuery(int id);
    }
}
