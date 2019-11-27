using KnockoutMVCApplication.ProductImage.Model;

namespace KnockoutMVCApplication.ProductImage.Command.AddProductImageCommand
{
    public interface IAddProductImageCommand
    {
        string ExecuteAddProductImage(AddProductImageModel addProductImageModel);
    }
}
