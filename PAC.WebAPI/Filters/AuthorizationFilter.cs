using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace PAC.WebAPI.Filters
{
    public class AuthorizationFilter : Attribute, IAuthorizationFilter
    {
        public virtual void OnAuthorization(AuthorizationFilterContext context)
        {
            var auth = context.HttpContext.Request.Headers["Authorization"].ToString();

            if (string.IsNullOrEmpty(auth))
            {
                context.Result = new ObjectResult(new { Message = "No puedo authorizarme" })
                {
                    StatusCode = 401
                };
            }
        }

    }
}

