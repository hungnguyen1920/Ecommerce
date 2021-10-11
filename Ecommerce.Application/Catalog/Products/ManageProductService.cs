using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Catalog.Products.DTOs;
using Ecommerce.Application.Catalog.Products.DTOs.Manage;
using Ecommerce.Application.CommomDTOs;
using Ecommerce.Data.EF;
using Ecommerce.Data.Entities;
using Ecommerce.Utilities.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Catalog.Products
{
    public class ManageProductService : IManagerProductService
    {
        private readonly EcommerceDbContext _dbContext;
        public ManageProductService(EcommerceDbContext context)
        {
            _dbContext = context;
        }

        public async Task AddViewCount(int productId)
        {
            var product = await _dbContext.Products.FindAsync(productId);
            product.ViewCount += 1;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Create(ProductCreateRequest request)
        {
            var createProduct = new Product()
            {
                Price = request.Price,
                OriginalPrice = request.OriginalPrice,
                Stock = request.Stock,
                ViewCount = 0,
                DateCreated = DateTime.Now,
                ProductTranslations = new List<ProductTranslation>()
                {
                    new ProductTranslation()
                    {
                        Name =  request.Name,
                        Description = request.Description,
                        Details = request.Details,
                        SeoDescription = request.SeoDescription,
                        SeoAlias = request.SeoAlias,
                        SeoTitle = request.SeoTitle,
                        LanguageId = request.LanguageId
                    }
                }
            };
            _dbContext.Products.Add(createProduct);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _dbContext.Products.FindAsync(productId);
            if (product == null)
            {
                throw new EcommerceException($"Cannot find a product: {productId}");
            }
            _dbContext.Products.Remove(product);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public async Task<PageResult<ProductViewModel>> GetAllPaging(GetManageProductPageRequest request)
        {
            // 1. Select Data
            var data = _dbContext.Products.Include("ProductTranslations")
                                          .Include("ProductCategoryMaps")
                                          .Include("Categories")
                                          .ToList();

            // 2. Filter
            if (!string.IsNullOrEmpty(request.KeyWork))
            {
                data = data.Where(x => x.ProductTranslations.FirstOrDefault(y => y.Name.Contains(request.KeyWork)))
            }
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdatePrice(int productId, decimal newPrice)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateStock(int productId, int addQuantity)
        {
            throw new System.NotImplementedException();
        }
    }
}