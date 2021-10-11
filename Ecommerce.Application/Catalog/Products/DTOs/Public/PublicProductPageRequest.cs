using Ecommerce.Application.CommonDTOs;

namespace Ecommerce.Application.Catalog.Products.DTOs.Public
{
    public class GetPublicProductPageRequest : PageRequestBase
    {
        public int CategoryId { get; set; }
    }
}