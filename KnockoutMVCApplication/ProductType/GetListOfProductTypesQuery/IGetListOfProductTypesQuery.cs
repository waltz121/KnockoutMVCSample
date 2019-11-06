using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.GetListOfProductTypesQuery
{
    public interface IGetListOfProductTypesQuery
    {
        List<ProductTypeListModel> Execute();
    }
}
