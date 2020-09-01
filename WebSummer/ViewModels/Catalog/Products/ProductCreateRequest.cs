using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Catalog.Products.Dtos
{
    public class ProductCreateRequest 
    {
       
        public decimal Price { set; get; }
        public decimal OriginalPrice { set; get; }
        public int Stock { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        public string SeoAlias { get; set; }

        public IFormFile ThumbnailImage { get; set; }
    }
}
