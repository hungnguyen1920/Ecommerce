using System.Collections.Generic;
using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.DTOs;
using Ecommerce.Data.EF;

namespace Ecommerce.Application.Catalog.Products
{
    public class ManageProductService : IManagerProductService
    {
        private readonly EcommerceDbContext _context;
        public ManageProductService(EcommerceDbContext context)
        {
            _context = context;
        }

        public int Create(ProductCreateRequest request)
        {
            throw new System.NotImplementedException();
        }

        public int Delete(int productId)
        {
            throw new System.NotImplementedException();
        }

        public List<ProductViewModel> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public PageViewModel<ProductViewModel> GetAllPaging(string keyWord, int pageIndex, int pageSize)
        {
            throw new System.NotImplementedException();
        }

        public int Update(ProductEditRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}