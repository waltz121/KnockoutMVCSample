using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventorySalesSampleApi.CodeRepository
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        string Update(T UpdatedEntity);
        string Add(T Newentity);
        string Delete(int id);
        IQueryable<T> Find(Expression<Func<T, bool>> predicate);
    }
}
