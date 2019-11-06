using KnockoutMVCSample.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCSample.Factory
{
    public interface IProductTypeViewModelFactory
    {
        ProductTypeViewModel CreateProductTypeViewModel();
    }
}
