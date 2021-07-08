using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Ev_N00036571.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

namespace Ev_N00036571.Servicios
{
    public interface IClaimService
    {
        User GetLoggedUser();
        void SetHttpContext(HttpContext httpContext);
        void Logout();
        void Login(ClaimsPrincipal principal);
    }

    public class ClaimService : IClaimService
    {
        private ExamenContext context;
        private HttpContext httpContext;

        public ClaimService(ExamenContext context)
        {
            this.context = context;
        }

        public void SetHttpContext(HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }

        public User GetLoggedUser()
        {
            var claim = httpContext.User.Claims.FirstOrDefault();
            var user = context.Usuarios.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }

        public void Logout()
        {
            httpContext.SignOutAsync();
        }

        public void Login(ClaimsPrincipal principal)
        {
            httpContext.SignInAsync(principal);
        }
    }
}
