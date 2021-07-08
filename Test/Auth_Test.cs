using System;
using System.Collections.Generic;
using System.Text;
using Ev_N00036571.Controllers;
using Ev_N00036571.Models;
using Ev_N00036571.Repositorio;
using Ev_N00036571.Servicios;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace Test
{
    class Auth_Test
    {
        [TestFixture]
        class AuthTest
        {
            [Test]
            public void LoginGet()
            {
                var controller = new AuthController(null, null);
                var view = controller.Login() as ViewResult;

                Assert.AreEqual("Login", view.ViewName);
            }
            [Test]
            public void LoginPostGood()
            {
                var repo = new Mock<IAuthRepositorio>();
                repo.Setup(o => o.GetUsuario("User", "user")).Returns(new User());

                var claim = new Mock<IClaimService>();

                var controller = new AuthController(repo.Object, claim.Object);
                var view = controller.Login("User", "user") as RedirectToActionResult;

                Assert.AreEqual("Index", view.ActionName);
            }

            [Test]
            public void LoginPostBad()
            {
                var repo = new Mock<IAuthRepositorio>();
                repo.Setup(o => o.GetUsuario("User", "user")).Returns(new User());

                var claim = new Mock<IClaimService>();

                var controller = new AuthController(repo.Object, claim.Object);
                var view = controller.Login(null, null) as ViewResult;

                Assert.AreEqual("Login", view.ViewName);
            }

            [Test]
            public void Logout()
            {
                var claim = new Mock<IClaimService>();

                var controller = new AuthController(null, claim.Object);
                var view = controller.Logout() as RedirectToActionResult;

                Assert.AreEqual("Login", view.ActionName);
            }

            [Test]
            public void RegisterGet()
            {
                var controller = new AuthController(null, null);
                var view = controller.Registrar() as ViewResult;

                Assert.AreEqual("Registrar", view.ViewName);
            }

            [Test]
            public void RegisterPostGood()
            {
                var repo = new Mock<IAuthRepositorio>();
                repo.Setup(o => o.GetUsuarios()).Returns(new List<User>());
                repo.Setup(o => o.SaveUsuario(new User()));
                var claim = new Mock<IClaimService>();

                var controller = new AuthController(repo.Object, claim.Object);
                var view = controller.Registrar(new User() { Password = "user" }, "user") as RedirectToActionResult;

                Assert.AreEqual("Login", view.ActionName);
            }

            [Test]
            public void RegisterPostBad()
            {
                var repo = new Mock<IAuthRepositorio>();
                repo.Setup(o => o.GetUsuarios()).Returns(new List<User>());

                var claim = new Mock<IClaimService>();

                var controller = new AuthController(repo.Object, claim.Object);
                var view = controller.Registrar(new User() { Password = "1223" }, "1234") as ViewResult;

                Assert.AreEqual("Registrar", view.ViewName);
            }

        }
    }

}
