 

using API.CORE.Entities;
using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.Mvc.Filters; 
using Microsoft.AspNetCore.Mvc;
using JsonResult = Microsoft.AspNetCore.Mvc.JsonResult;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = (User)context.HttpContext.Items["User"];
        if (user == null)
        {
            // not logged in
           context.Result = new JsonResult(new { message = "Unauthorized" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }
}