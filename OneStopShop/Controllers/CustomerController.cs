using BLL.DTOs;
using BLL.Services;
using OneStopShop.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneStopShop.Controllers
{
    public class CustomerController : ApiController
    {
        [Route("api/customer/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserAddCusDTO User)
        {
            try
            {
                User.UserType = "Customer";
                var data = CustomerServices.AddCustomer(User);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [Route("api/customer/get")]
        [HttpGet]
        [CustomerLogin]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CustomerServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/get/{id}")]
        [HttpGet]
        [Logged]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = CustomerServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/update")]
        [HttpPost]
        [CustomerLogin]
        public HttpResponseMessage Update(CustomerDTO User)
        {
            try
            {
                var data = CustomerServices.Update(User);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/delete/{id}")]
        [HttpGet]
        [CustomerLogin]
        public HttpResponseMessage Delete(int ID)
        {
            try
            {
                var data = CustomerServices.Delete(ID);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
