using InventorySalesSampleApi.CodeRepository;
using InventorySalesSampleApi.Models;
using System;
using Unity;

namespace InventorySalesSampleApi.UnitOfWork
{
    public class InventorySalesUnitOfWork : IUnitOfWork
    {

        InventorySalesDBEntities dBEntities;
        public InventorySalesUnitOfWork(IRepository<Product> productRepository, InventorySalesDBEntities dBEntities)
        {
            this.dBEntities = dBEntities;
            ProductRepository = productRepository;
        }

        public IRepository<Product> ProductRepository 
        {
            get;
        }

        public IRepository<Product_Types> ProductTypeRepository
        {
            get;
        }

        public string Commit()
        {
            try
            {
                dBEntities.SaveChanges();
                return "Success";
            }
            catch(Exception ex)
            {
                ArgumentException argumentException = new ArgumentException("Error: " + ex.Message);
                throw argumentException;
            }
        }
    }
}