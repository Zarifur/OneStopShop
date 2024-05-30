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
    public class TypeController : ApiController
    {
        [Route("api/type/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TypeServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
