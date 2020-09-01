using ViewModels.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModels.Catalog.Products.Dtos
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }

        public List<int> CategoryIds { get; set; }
    }
}
