using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Ev_N00036571.Models;
using Microsoft.Extensions.Configuration;

namespace Ev_N00036571.Repositorio
{
    public interface IAuthRepositorio
    {
        User GetUsuario(string username, string password);
        void SaveUsuario(User user);
        List<User> GetUsuarios();
    }
    public class AuthRepositorio : IAuthRepositorio
    {
        private readonly IExamenContext context;
        private readonly IConfiguration configuration;

        public AuthRepositorio(IExamenContext context, IConfiguration configuration)
        {
            this.context = context;
            this.configuration = configuration;
        }

        public User GetUsuario(string username, string password)
        {
            return context.Usuarios.Where(o => o.Username == username && o.Password == CreateHash(password)).FirstOrDefault();
        }

        public List<User> GetUsuarios()
        {
            return context.Usuarios.ToList();
        }

        public void SaveUsuario(User user)
        {
            user.Password = CreateHash(user.Password);
            context.Usuarios.Add(user);
            context.SaveChanges();
        }

        protected string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }
    }
}
