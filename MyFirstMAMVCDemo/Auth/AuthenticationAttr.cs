using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Filters;

namespace MyFirstMAMVCDemo.Auth
{
    public class AuthenticationAttr : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserId"] == null)
            {
                filterContext.Result = new HttpUnauthorizedResult();
            }
            //throw new NotImplementedException();
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
            filterContext.Result = new ViewResult
            {
                ViewName = "Error"
            };           //throw new NotImplementedException();
        }
    }
}