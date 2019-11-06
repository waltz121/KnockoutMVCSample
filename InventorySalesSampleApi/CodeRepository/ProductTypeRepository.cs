using InventorySalesSampleApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace InventorySalesSampleApi.CodeRepository
{
    public class ProductTypeRepository : IRepository<Product_Types>
    {
        private readonly InventorySalesDBEntities DBEntities;

        public ProductTypeRepository(InventorySalesDBEntities DBEntities)
        {
            this.DBEntities = DBEntities;
        }

        public string Add(Product_Types Newentity)
        {
            DBEntities.Product_Types.Add(Newentity);
            return "Newly Added State";
        }

        public string Delete()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product_Types> Find(Expression<Func<Product_Types, bool>> predicate)
        {
            return DBEntities.Product_Types.Where(predicate);
        }

        public Product_Types Get(int id)
        {
            return DBEntities.Product_Types.Where(x => x.Product_Type_Code == id).SingleOrDefault();
        }

        public IEnumerable<Product_Types> GetAll()
        {
            return DBEntities.Product_Types.OrderBy(x => x.Product_Type_Code).ToList();
        }

        public string Update(Product_Types UpdatedEntity)
        {
            DBEntities.Entry(UpdatedEntity).State = EntityState.Modified;
            return "Modified State";
        }
    }
}