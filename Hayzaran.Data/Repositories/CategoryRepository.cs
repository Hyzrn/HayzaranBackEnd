using Hayzaran.Core.Entities;
using Hayzaran.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hayzaran.Data.Repositories
{
    public class CategoryRepository : Repository<Category>,ICategoryRepository
    {
        private AppDbContext appDbContext { get => context as AppDbContext; }

        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<Category> GetWithProductsByIdAsync(int categoryId)
        {
            return await appDbContext.Categories.Include(x => x.Products).SingleOrDefaultAsync(x => x.Id == categoryId);
        }
    }
}
