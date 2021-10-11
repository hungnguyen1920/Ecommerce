using System.Collections.Generic;
using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.DTOs;

namespace Ecommerce.Application.Catalog.Products
{
    public interface IManagerProductService
    {
        int Create(ProductCreateRequest request);
        int Update(ProductEditRequest request);
        int Delete(int productId);
        List<ProductViewModel> GetAll();
        PageViewModel<ProductViewModel> GetAllPaging(string keyWord, int pageIndex, int pageSize);
    }
}