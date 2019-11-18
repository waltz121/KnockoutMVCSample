using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductType.GetViaIdProductTypesQuery
{
    public interface IGetViaIdProductTypesQuery
    {
        ProductTypeDetailModel ExecuteQuery(int id);
    }
}
