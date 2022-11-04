using API_DSCC_8883.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_DSCC_8883.Repository
{
    public interface IProductRepository
    {
        void InsertProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        Product GetProductById(int Id);
        IEnumerable<Product> GetProducts();
    }
}
