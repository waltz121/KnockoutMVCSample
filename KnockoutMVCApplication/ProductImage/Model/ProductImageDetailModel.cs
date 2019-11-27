using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCApplication.ProductImage.Model
{
    public class ProductImageDetailModel
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
