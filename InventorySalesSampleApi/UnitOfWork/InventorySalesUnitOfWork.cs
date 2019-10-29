using InventorySalesSampleApi.CodeRepository;
using InventorySalesSampleApi.Models;
using System;

namespace InventorySalesSampleApi.UnitOfWork
{
    public class InventorySalesUnitOfWork : IUnitOfWork
    {
        InventorySalesDBEntities DBEntities;
        public InventorySalesUnitOfWork(InventorySalesDBEntities DBEntities)
        {
            this.DBEntities = DBEntities;

            ProductRepository = new ProductRepository(DBEntities);
        }
        public IRepository<Product> ProductRepository 
        {
            get;
        }

        public string Commit()
        {
            try
            {
                DBEntities.SaveChanges();
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