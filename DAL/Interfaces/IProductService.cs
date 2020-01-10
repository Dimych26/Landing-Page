using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Interfaces
{
    public interface IProductService
    {
        Product GetItem(Expression<Func<Product, bool>> predicate);
        IEnumerable<Product> GetAll(Expression<Func<Product, bool>> predicate);
        IEnumerable<Product> GetAllItem();
       
    }
}
