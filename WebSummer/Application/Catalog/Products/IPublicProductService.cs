using ViewModels.Catalog.Products.Dtos;
using ViewModels.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Catalog.Products
{
    public interface IPublicProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(GetPublicProductPagingRequest request);

        //Task<List<ProductViewModel>> GetAll();
    }
}
