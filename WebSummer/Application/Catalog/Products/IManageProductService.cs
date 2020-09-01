using ViewModels.Catalog.Products.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Dtos;
namespace Application.Catalog.Products
{
    public interface IManageProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<List<ProductViewModel>> GetAll();

        Task<int> Update(ProductUpdateRequest request);

        Task<int> Delete(int productId);

        Task<bool> UpdatePrice(int productId, decimal newPrice);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task AddViewcount(int productId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        //Task<int> AddImages(int productId, List<IFormFile> files);

        //Task<int> RemoveImages(int imageId);

        //Task<int> UpdateImage(int imageId, string caption, bool isDefault);

        //Task<List<ProductImageViewModel>> GetListImage(int productId);


    }
}
