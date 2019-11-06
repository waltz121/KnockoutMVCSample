using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KnockoutMVCApplication.ProductType.GetListOfProductTypesQuery;
using KnockoutMVCSample.Models.ViewModels;

namespace KnockoutMVCSample.Factory
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