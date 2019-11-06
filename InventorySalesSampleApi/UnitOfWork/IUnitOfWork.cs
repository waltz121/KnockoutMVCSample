using InventorySalesSampleApi.CodeRepository;
using InventorySalesSampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesSampleApi.UnitOfWork
{
    public interface IUnitOfWork
    {
        IRepository<Product> ProductRepository { get; }

        IRepository<Product_Types> ProductTypeRepository { get; }
        string Commit();
    }
}
