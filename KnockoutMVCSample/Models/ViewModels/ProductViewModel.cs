using KnockoutMVCApplication.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutMVCSample.Models.ViewModels
{
    public class ProductViewModel
    {
        public List<ProductGridModel> ProductGridModels { get; set; }
        public string TestProductVar1 { get; set; }
        public string TestProductVar2 { get; set; }
    }
}