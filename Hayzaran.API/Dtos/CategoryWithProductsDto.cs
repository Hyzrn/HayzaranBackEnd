using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hayzaran.API.Dtos
{
    public class CategoryWithProductsDto:CategoryDto
    {
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
