using InventorySalesSampleApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Unity;

namespace InventorySalesSampleApi.CodeRepository
{
    public class ProductRepository : IRepository<Product>
    {

        InventorySalesDBEntities DBEntities;
     
        public ProductRepository(InventorySalesDBEntities DBEntities)
        {
            this.DBEntities = DBEntities;
        }

        public string Add(Product Newentity)
        {
            DBEntities.Products.Add(Newentity);
            return "Newly Added State";
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> Find(Expression<Func<Product, bool>> predicate)
        {
            return DBEntities.Products.Where(predicate);
        }

        public Product Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return DBEntities.Products.OrderBy(x => x.Id).ToList();
        }

        public string Update(Product UpdatedEntity)
        {
            DBEntities.Entry(UpdatedEntity).State = EntityState.Modified;
            return "Modified State";
        }
    }
}