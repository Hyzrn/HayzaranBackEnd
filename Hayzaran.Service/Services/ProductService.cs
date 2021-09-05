using Hayzaran.Core.Entities;
using Hayzaran.Core.Repositories;
using Hayzaran.Core.Services;
using Hayzaran.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hayzaran.Service.Services
{
    public class ProductService : Service<Product>,IProductService
    {
        public ProductService(IUnitOfWork unitOfWork, IRepository<Product> repository) : base(unitOfWork, repository)
        {
        }
            
        public async Task<Product> GetWithCategoryByIdAsync(int productId)
        {
            return await unitOfWork.Products.GetWithCategoryByIdAsync(productId);
        }
    }
}
