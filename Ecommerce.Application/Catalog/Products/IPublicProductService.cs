using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.Catalog.Products.DTOs.Public;
using Ecommerce.Application.CommomDTOs;

namespace Ecommerce.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageResult<ProductViewModel> GetAllByCategoryId(GetPublicProductPageRequest request);
    }
}