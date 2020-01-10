using DAL.Context;
using DAL.Entities;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;



namespace DAL.Services
{
    public class ProductService : IProductService
    {
        private readonly TrialContext db = new TrialContext();

       

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> predicate)
        {
            
            return db.Products.AsNoTracking().Where(predicate).ToList();
        }

        public IEnumerable<Product> GetAllItem()
        {
           
            return db.Products.AsNoTracking().ToList();
        }

        public Product GetItem(Expression<Func<Product, bool>> predicate)
        {
            return db.Products.AsNoTracking().FirstOrDefault(predicate);
        }
    }
}
