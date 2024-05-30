using BLL.DTOs;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OneStopShop.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ProductController : ApiController
    {
        [Route("api/product/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ProductServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/product/add")]
        [HttpPost]
        public HttpResponseMessage Add(AddProductDTO Em)
        {
            try
            {
                //Em.UserType = "Employee";
                var data = ProductServices.AddProduct(Em);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/product/get/{uid}")]
        [HttpGet]
        //[IsLogged]
        public HttpResponseMessage Get(int uid)
        {
            try
            {
                var data = ProductServices.Get(uid);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/product/updateproduct")]
        [HttpPost]
        //[CustomerLogin]
        public HttpResponseMessage UpdateProduct(AddProductDTO pro)
        {
            try
            {
                var data = ProductServices.UpdateProduct(pro);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/product/update")]
        [HttpPost]
        //[CustomerLogin]
        public HttpResponseMessage Update(ProductDTO pro)
        {
            try
            {
                var data = ProductServices.Update(pro);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/Product/delete/{id}")]
        [HttpDelete]
        //[CustomerLogin]
        public HttpResponseMessage Delete(int ID)
        {
            try
            {
                var data = ProductServices.Delete(ID);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/product/tag/{tag}")]
        [HttpGet]
        //[IsLogged]
        public HttpResponseMessage GetTag(string tag)
        {
            try
            {
                var data = ProductServices.GetTag(tag);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
