using KnockoutMVCApplication.ProductType.AddProductTypeCommand.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.AddProductTypeCommand
{
    public interface IAddProductTypeCommand
    {
        void ExecuteCommand(AddProductTypeModel addProductTypeModel);
    }
}
