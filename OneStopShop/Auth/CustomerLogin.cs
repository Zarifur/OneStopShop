using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace OneStopShop.Auth
{
    public class CustomerLogin: AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var token = actionContext.Request.Headers.Authorization;
            var tokenkUser = actionContext.Request.Headers.GetValues("Email").FirstOrDefault();

            var tokenData = AuthServices.IsTokenValid(token.ToString());
            if (token == null || tokenkUser == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "No token supplied");

            }
            else if (tokenData == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "Supplied Token is invalid or expired");
            }
            else if (tokenData != null)
            {
                var user = UserServices.Get(tokenData.UId);
                if (user == null || user.UserType != "Customer")
                {
                    actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "You cannot access this!");
                }
                else
                {
                    var validUser = UserServices.Get(Int16.Parse(tokenkUser));
                    if (validUser == null || validUser.UId != user.UId)
                    {
                        actionContext.Response = actionContext.Request.CreateResponse(System.Net.HttpStatusCode.Unauthorized, "You are not the correct user!");
                    }

                }
            }
            base.OnAuthorization(actionContext);
        }
    }
}