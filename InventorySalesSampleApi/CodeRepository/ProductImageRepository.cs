using InventorySalesSampleApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace InventorySalesSampleApi.CodeRepository
{
    public class ProductImageRepository : IRepository<Product_Image>
    {
        private readonly InventorySalesDBEntities dBEntities;

        public ProductImageRepository(InventorySalesDBEntities dBEntities)
        {
            this.dBEntities = dBEntities;
        }

        public string Add(Product_Image Newentity)
        {
            dBEntities.Product_Image.Add(Newentity);
            return "Newly Added State";
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product_Image> Find(Expression<Func<Product_Image, bool>> predicate)
        {
            return dBEntities.Product_Image.Where(predicate);
        }

        public Product_Image Get(int id)
        {
            return dBEntities.Product_Image.Where(x => x.Id == id).SingleOrDefault();
        }

        public IEnumerable<Product_Image> GetAll()
        {
            return dBEntities.Product_Image.OrderBy(x => x.Id).ToList();
        }

        public string Update(Product_Image UpdatedEntity)
        {
            dBEntities.Entry(UpdatedEntity).State = EntityState.Modified;
            return "Modified State";
        }
    }
}