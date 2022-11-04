using API_DSCC_8883.DbContexts;
using API_DSCC_8883.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _dbContext;
        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            Save();
        }
        public Product GetProductById(int productId)
        {
            var prod = _dbContext.Products.Find(productId);
            //_dbContext.Entry(prod).Reference(s => s.Category).Load();
            return prod;
        }
        public IEnumerable<Product> GetProducts()
        {
            var prods = _dbContext.Products.ToList();
            //return _dbContext.Products.Include(s => s.Category).ToList();
            return prods;
        }
        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

    }
}
