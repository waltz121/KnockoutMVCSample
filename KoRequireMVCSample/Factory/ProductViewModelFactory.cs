using KnockoutMVCApplication.Product;
using KnockoutMVCApplication.Product.GetListProductsQuery;
using KoRequireMVCSample.Models.ViewModels;
using System.Collections.Generic;

namespace KoRequireMVCSample.Factory
{
    public class ProductViewModelFactory : IProductViewModelFactory
    {
        private readonly IGetListProductsQuery getListProductsQuery;

        public ProductViewModelFactory(IGetListProductsQuery getListProductsQuery)
        {
            this.getListProductsQuery = getListProductsQuery;
        }
        public ProductViewModel CreateProductViewModel()
        {
            ProductViewModel viewModel = new ProductViewModel();
            viewModel.ProductGridModels = new List<ProductGridModel>();
            viewModel.TestProductVar1 = "Testing this";
            viewModel.TestProductVar2 = "Testing That";
            viewModel.ProductGridModels = getListProductsQuery.Execute();

            return viewModel;
        }
    }
}