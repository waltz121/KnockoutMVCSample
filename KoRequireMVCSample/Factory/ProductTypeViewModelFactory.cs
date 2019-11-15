using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnockoutMVCApplication.ProductType.GetListOfProductTypesQuery;
using KoRequireMVCSample.Models.ViewModels;

namespace KoRequireMVCSample.Factory
{
    public class ProductTypeViewModelFactory : IProductTypeViewModelFactory
    {
        private readonly IGetListOfProductTypesQuery getListOfProductTypesQuery;

        public ProductTypeViewModelFactory(IGetListOfProductTypesQuery getListOfProductTypesQuery)
        {
            this.getListOfProductTypesQuery = getListOfProductTypesQuery;
        }

        public ProductTypeViewModel CreateProductTypeViewModel()
        {
            ProductTypeViewModel productTypeViewModel = new ProductTypeViewModel();
            productTypeViewModel.ProductTypeListModels = getListOfProductTypesQuery.Execute();

            return productTypeViewModel;
        }
    }
}