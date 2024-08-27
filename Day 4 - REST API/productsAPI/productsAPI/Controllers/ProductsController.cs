using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace productsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        Products pObj = new Products(); //this is a bad code, old fashion
                                        //we use DI instead
                                        //Dependency Injection


        //we will have to specify what this method does for client
        [HttpGet]  //2. What is this method doing
        [Route("/products/list")] //3. How will they access this method
        public IActionResult GetAllProducts()
        {
            //1. this will always return HttpStatus Code and data
            var data = pObj.AllProducts();
            return Ok(data);

        }

        [HttpGet]
        [Route("/products/id/{id}")]
        public IActionResult GetProductById(int id) 
        {
        
            try
            {
                var p = pObj.ProductById(id);
                return Ok(p);
            }
            catch (Exception ex) 
            {
                return NotFound(ex.Message);
            }
        }

        [HttpGet]
        [Route("/products/category/{category}")]
        public IActionResult GetProductsByCategory(string category) 
        {
            try
            {
                var p = pObj.ProductByCategory(category);
                return Ok(p);
            }
            catch (Exception es)
            {

                return NotFound(es.Message);
            }
        }

        [HttpGet]
        [Route("/products/instock/{trueorfalse}")]
        public IActionResult GetProductInStock(bool trueorfalse)
        {
            try
            {
                var p = pObj.ProductByAvability(trueorfalse);
                return Ok(p);
            }
            catch (Exception es)
            {
                return NotFound(es.Message);
                
            }

        }

        [HttpGet]
        [Route("/products/count")]
        public IActionResult GetTotalProducts()
        {
            var total = pObj.ProductsCount();
            return Ok(total);
        }

        [HttpPost]
        [Route("/products/add")]
        public IActionResult AddProduct([FromBody]Products newProduct)
        {
            try
            {
               string add = pObj.AddNewProduct(newProduct);
                return Created("", add);
            }
            catch (Exception es)
            {
                return BadRequest(es.Message);               
            }
        }
        [HttpDelete]
        [Route("/products/delete/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                var delete = pObj.RemoveProduct(id);
                return Accepted(delete);
            }
            catch (Exception es)
            {
                return BadRequest(es.Message);               
            }
        }

        [HttpPut]
        [Route("/products/edit")]
        public IActionResult EditProduct([FromBody]Products products)
        {
            try
            {
                var edit = pObj.EditProduct(products);
                return Accepted(edit);
            }
            catch (Exception es)
            {
                return BadRequest(es.Message); 
            }
        }

    }
}








