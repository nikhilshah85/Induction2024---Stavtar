using shoppingAPI.Models;

namespace shoppingAPI.Repository
{
    public class ProductsRepository
    {

        ShoppingDb2Context db = new ShoppingDb2Context(); //use DI instead


        public List<Product> ProductByCategory(string categoryName)
        {
            var pr = (from p in db.Products
                     where p.PCategory == categoryName
                     select p).ToList();

            return pr;
        }

        public int ProductCount()
        {
            return db.Products.Count();
        }

        public List<Product> GetProductsMatchingNames(string startwith)
        {
                var pr = (from p in db.Products
                         where p.PName.StartsWith(startwith) 
                         select p).ToList();

                return pr;

        }


    }
}

