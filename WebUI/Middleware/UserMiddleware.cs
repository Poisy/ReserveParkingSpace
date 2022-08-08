using System;
using System.Threading.Tasks;
using Infrastructure.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace WebUI.Middleware
{
    public class UserMiddleware
    {
        private readonly RequestDelegate _next;

        public UserMiddleware(RequestDelegate nextDelegate)
        {
            _next = nextDelegate;
        }

        public async Task Invoke(HttpContext context, UserManager<IdentityUser> userManager, UserService userService)
        {
            if (context.User != null && context.User.Identity.IsAuthenticated)
            {
                var user = await userService.GetAsync(new Guid(userManager.GetUserId(context.User)));
                context.Items.Add("user", user);
            }

            await _next(context);
        }
    }
}