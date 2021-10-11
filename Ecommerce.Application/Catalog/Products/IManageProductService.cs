using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.Catalog.Products.DTOs.Manage;
using Ecommerce.Application.CommomDTOs;

namespace Ecommerce.Application.Catalog.Products
{
    public interface IManagerProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<List<ProductViewModel>> GetAll();
        Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPageRequest request);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addQuantity);
        Task AddViewCount(int productId);
    }
}