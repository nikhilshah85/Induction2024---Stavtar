namespace productsAPI
{
    public class Products
    {
        #region Properties
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public bool pIsInStock { get; set; }
        public int pPrice { get; set; }
        #endregion

        #region Data
       private static List<Products> pList = new List<Products>()
        { 
            new Products() { pId=101, pName="Pepsi", pCategory="Cold-Drink", pPrice=50, pIsInStock=true},
            new Products() { pId=102, pName="Nike", pCategory="Shoes", pPrice=5000, pIsInStock=true},
            new Products() { pId=103, pName="Boat", pCategory="Speaker", pPrice=1200, pIsInStock=false},
            new Products() { pId=104, pName="IPhone", pCategory="Phone", pPrice=150000, pIsInStock=true},
            new Products() { pId=105, pName="Samsung Galaxy", pCategory="Phone", pPrice=110000, pIsInStock=true},
            new Products() { pId=106, pName="Appy", pCategory="Cold-Drink", pPrice=80, pIsInStock=false},
            new Products() { pId=107, pName="Fanta", pCategory="Cold-Drink", pPrice=70, pIsInStock=true},
            new Products() { pId=108, pName="Adidas", pCategory="Shoes", pPrice=8000, pIsInStock=true},
         };
        #endregion

        #region Get Methods
        //get all products
        public List<Products> AllProducts()
        {
            return pList;
        }
     
        public Products ProductById(int id)
        {
            var pr = (from p in pList
                    where p.pId == id
                    select p).Single();
            if (pr != null)
            {
                return pr;
            }
            throw new Exception("Product with Id" + id + " Not found");
        }

        public List<Products> ProductByCategory(string  category)
        {
            var pr = (from p in pList
                      where p.pCategory == category
                      select p).ToList();

            if (pr.Count > 0)
            {
                return pr;
            }
            throw new Exception("Products not found for category : " + category);
        }

        public List<Products> ProductByAvability(bool trueorfalse)
        {
            var pr = (from p in pList
                     where p.pIsInStock == trueorfalse
                     select p).ToList();
            if (pr.Count > 0)
            {
                return pr;
            }
            throw new Exception("0 products found");
        }

        public int ProductsCount()
        {
            return pList.Count;
        }
        #endregion

        #region Add, update and Edit product
        public string AddNewProduct(Products p)
        {
            //we can do validations here, formating, calculation etc.
            if(p.pName.Length < 3)
            {
                throw new Exception("Please enter valid product name");
            }
            pList.Add(p);
            return "Product Added Successfully";
        }

        public string RemoveProduct(int id)
        {
            var pr = (from p in pList
                     where p.pId == id
                     select p).Single();
            if(pr != null) 
            {
                pList.Remove(pr);
                return "Product Removed Successfully";
            }
            throw new Exception("Product Not Found");
        }

        public string EditProduct(Products pObj)
        {
            var pr = (from p in pList
                      where p.pId == pObj.pId
                      select p).Single();

            if (pr != null)
            {
                pr.pName = pObj.pName;
                pr.pCategory = pObj.pCategory;
                pr.pPrice = pObj.pPrice;
                pr.pIsInStock = pObj.pIsInStock;
                return "Product details Updated";
            }
            throw new Exception("Product Not found");
        }
        #endregion
    }
}




