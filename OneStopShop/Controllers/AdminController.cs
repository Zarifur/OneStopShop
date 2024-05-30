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
    public class AdminController : ApiController
    {
        [Route("api/admin/add")]
        [HttpPost]
        public HttpResponseMessage Add(UserAddCusDTO User)
        {
            try
            {
                User.UserType = "Admin";
                var data = AdminServices.AddAdmin(User);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [Route("api/admin/get")]
        [HttpGet]
        [AdminLogin]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AdminServices.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/admin/get/{id}")]
        [HttpGet]
        [Logged]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AdminServices.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/admin/update")]
        [HttpPost]
        [AdminLogin]
        public HttpResponseMessage Update(AdminDTO User)
        {
            try
            {
                var data = AdminServices.Update(User);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/admin/delete/{id}")]
        [HttpGet]
        [AdminLogin]
        public HttpResponseMessage Delete(int ID)
        {
            try
            {
                var data = AdminServices.Delete(ID);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
