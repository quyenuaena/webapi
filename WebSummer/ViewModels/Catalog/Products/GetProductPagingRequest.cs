using ViewModels.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Catalog.Products.Dtos
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
