using System.Collections.Generic;
using Ecommerce.Application.CommonDTOs;

namespace Ecommerce.Application.Catalog.Products.DTOs.Manage
{
    public class GetManageProductPageRequest : PageRequestBase
    {
        public string KeyWork { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}