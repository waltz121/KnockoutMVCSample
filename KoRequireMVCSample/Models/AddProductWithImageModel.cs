﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KoRequireMVCSample.Models
{
    public class AddProductWithImageModel
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}