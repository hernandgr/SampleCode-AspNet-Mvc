using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiDemo.Api.Models;

namespace WebApiDemo.Api.Controllers
{
    public class ProductsController : ApiController
    {
        // GET api/Products
        public IEnumerable<Product> GetProducts()
        {
            return this.GetProductsList();
        }

        // GET api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = this.GetProductsList().Where(p => p.Id == id).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        private IEnumerable<Product> GetProductsList()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "T-Shirt", Price = 20 });
            products.Add(new Product() { Id = 2, Name = "Hat", Price = 10 });

            return products;
        }
    }
}