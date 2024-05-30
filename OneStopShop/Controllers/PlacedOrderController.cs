using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneStopShop.Controllers
{
    public class PlacedOrderController : ApiController
    {
        [Route("api/placedorder/get")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = PlacedOrderServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/placedorder/add")]
        [HttpPost]
        public HttpResponseMessage Add(PlacedOrderDTO Em)
        {
            try
            {
                //Em.UserType = "Employee";
                var data = PlacedOrderServices.Add(Em);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/placedorder/update")]
        [HttpPost]
        public HttpResponseMessage Update(PlacedOrderDTO e)
        {
            try
            {
                var data = PlacedOrderServices.Update(e);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
