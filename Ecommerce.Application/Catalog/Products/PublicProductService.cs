using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.Catalog.Products.DTOs.Public;
using Ecommerce.Application.CommomDTOs;

namespace Ecommerce.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public PageResult<ProductViewModel> GetAllByCategoryId(GetPublicProductPageRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}