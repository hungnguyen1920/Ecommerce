using System.Collections.Generic;

namespace Ecommerce.Application.DTOs
{
    public class PageViewModel<T>
    {
        public int TotalRecord { get; set; }
        public List<T> Items { get; set; }
    }
}