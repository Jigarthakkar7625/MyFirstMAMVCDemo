using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MyFirstMAMVCDemo.JigarAuth
{
    public class AuthorisedAttr : AuthorizeAttribute
    {

        //Entities context = new Entities(); // my entity  
        private readonly string[] allowedroles;
        public AuthorisedAttr(params string[] roles)
        {
            this.allowedroles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = true;
            var a = httpContext.User.Identity.GetUserId();
            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Result = new HttpUnauthorizedResult();
        }

    }
}