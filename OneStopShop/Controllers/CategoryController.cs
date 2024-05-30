using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace OneStopShop.Controllers
{
    [EnableCors("*", "*", "*")]
    public class CategoryController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [Route("api/category/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CategoryServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
