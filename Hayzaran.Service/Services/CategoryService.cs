using Hayzaran.Core.Entities;
using Hayzaran.Core.Repositories;
using Hayzaran.Core.Services;
using Hayzaran.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hayzaran.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> repository) : base(unitOfWork, repository)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await unitOfWork.Categories.GetWithProductsByIdAsync(categoryId);
        }
    }
}
