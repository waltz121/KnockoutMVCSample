using KnockoutMVCApplication.ProductImage.Command.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductImage.Command.AddProductImageCommand
{
    public interface IAddProductImageCommand
    {
        string ExecuteAddProductImage(AddProductImageModel addProductImageModel);
    }
}
