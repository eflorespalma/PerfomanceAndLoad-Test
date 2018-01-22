using Course.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Course.Data.ProductRepository
{
    public class ProductData
    {
        readonly DatabaseService _databaseService;
        public ProductData()
        {
            _databaseService = new DatabaseService();
        }
        public List<Product> GetAll()
        {

            return _databaseService.Product.ToList();
        }
        public Product GetProduct(int Id)
        {
            return _databaseService.Product.Where(x => x.Id == Id).SingleOrDefault();
        }
        public int SaveProduct(Product product)
        {
            _databaseService.Product.Add(product);
            _databaseService.Save();
            return product.Id;
        }
        public void UpdateProduct(Product product)
        {
            _databaseService.Entry(product).State = EntityState.Modified;
            _databaseService.Product.AddOrUpdate(product);
            _databaseService.Save();
        }
        public void RemoveProduct(Product product)
        {
            _databaseService.Entry(product).State = EntityState.Deleted;
            _databaseService.Product.Attach(product);
            _databaseService.Product.Remove(product);
            _databaseService.Save();
        }
    }
}
