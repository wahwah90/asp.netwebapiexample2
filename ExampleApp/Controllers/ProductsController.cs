using System.Collections.Generic;
using System.Web.Http;
using ExampleApp.Models;
using ExampleApp.Infrastructure;

namespace ExampleApp.Controllers {
    public class ProductsController : ApiController {
        IRepository repo;

        public ProductsController(IRepository repoImpl) {
            repo = repoImpl;
        }

        public IHttpActionResult GetAll()
        {
            return Ok(repo.Products);
        }
        //public IHttpActionResult Delete(int id)
        //{
        //    repo.DeleteProduct(id);
        //    return StatusCode(System.Net.HttpStatusCode.NoContent);
        //}
        //public IHttpActionResult Delete(int id)
        //{
        //    repo.DeleteProduct(id);
        //    return ResponseMessage(new System.Net.Http.HttpResponseMessage(System.Net.HttpStatusCode.NoContent));
        //}
        public IHttpActionResult Delete(int id)
        {
            repo.DeleteProduct(id);
            return new NoContentResult();
        }
        [HttpGet]
        [Route("api/products/noop")]
        public IHttpActionResult NoOp()
        {
            return Ok(); 
        }
    }
}
