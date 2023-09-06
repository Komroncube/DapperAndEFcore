using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperAndEFcore.Service.EFcore
{
    public class ProductService
    {
        private ShopDB _db = new ShopDB();
        public void AddProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }
        public void RemoveProduct(int productId)
        {
            var entity = _db.Products.FirstOrDefault(x=>x.Id == productId);
            _db.Products.Remove(entity);
            _db.SaveChanges();
        }
        public void UpdateProduct(Product product)
        {
            _db.Products.Update(product);
            _db.SaveChanges();
        }
        public void DeleteProduct(int productId)
        {
            var entity = GetProductById(productId);
            if (entity != null)
            {
                _db.Products.Remove(entity);
                _db.SaveChanges();
            }
        }
        public List<Product> GetAllProducts()
        {
            return _db.Products.ToList();
        }
        public Product GetProductById(int productId)
        {
            return _db.Products.FirstOrDefault(p => p.Id == productId);
        }
    }
}
