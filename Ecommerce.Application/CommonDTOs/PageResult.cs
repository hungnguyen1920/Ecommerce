using System.Collections.Generic;

namespace Ecommerce.Application.CommomDTOs
{
    public class PageResult<T>
    {
        public int TotalRecord { get; set; }
        public List<T> Items { get; set; }
    }
}