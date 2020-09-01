using ViewModels.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Catalog.Products.Dtos
{
    public class GetPublicProductPagingRequest:PagingRequestBase
    {
        public int CategoryId { get; set; }
    }
}
