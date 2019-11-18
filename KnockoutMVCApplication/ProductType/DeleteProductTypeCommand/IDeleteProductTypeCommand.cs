using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.DeleteProductTypeCommand
{
    public interface IDeleteProductTypeCommand
    {
        string ExecuteCommand(int id);
    }
}
