using KnockoutMVCApplication.ProductImage.Query.GetAllProductImageQuery;
using KoRequireMVCSample.Models.ViewModels;
using System;

namespace KoRequireMVCSample.Factory
{
    public class ProductImageViewModelFactory : IProductImageViewModelFactory
    {
        private readonly IGetAllProductImageQuery getAllProductImageQuery;

        public ProductImageViewModelFactory(IGetAllProductImageQuery getAllProductImageQuery)
        {
            this.getAllProductImageQuery = getAllProductImageQuery;
        }
        public ProductImagesViewModel CreateProductImagesViewModel()
        {
            ProductImagesViewModel productImagesViewModel = new ProductImagesViewModel();
            productImagesViewModel.ProductImageLists = getAllProductImageQuery.ExecuteGetAllProductImage();

            return productImagesViewModel;
        }
    }
}