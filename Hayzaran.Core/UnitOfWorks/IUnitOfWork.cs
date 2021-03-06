using Hayzaran.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hayzaran.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        IProductRepository Products { get;}
        ICategoryRepository Categories { get; }

        Task CommitAsync();
        void Commit();
    }
}
