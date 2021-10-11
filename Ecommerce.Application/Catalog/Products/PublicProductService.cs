using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Catalog.Products
{
    public class PublicProductService : IPublicProductService
    {
        public PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize)
        {
            throw new System.NotImplementedException();
        }
    }
}