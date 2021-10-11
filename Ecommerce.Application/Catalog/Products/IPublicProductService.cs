using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Catalog.Products
{
    public interface IPublicProductService
    {
        PageViewModel<ProductViewModel> GetAllByCategoryId(int categoryId, int pageIndex, int pageSize);
    }
}