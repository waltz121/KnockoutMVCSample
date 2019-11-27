using KoRequireMVCSample.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoRequireMVCSample.Factory
{
    public interface IProductImageViewModelFactory
    {
        ProductImagesViewModel CreateProductImagesViewModel();
    }
}
