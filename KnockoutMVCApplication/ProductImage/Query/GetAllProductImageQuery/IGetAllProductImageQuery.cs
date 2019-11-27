using KnockoutMVCApplication.ProductImage.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductImage.Query.GetAllProductImageQuery
{
    public interface IGetAllProductImageQuery
    {
        List<ProductImageListModel> ExecuteGetAllProductImage();
    }
}
