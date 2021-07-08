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
    public class Nota_Test
    {
        [Test]
        public void Index()
        {
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());
            repo.Setup(o => o.GetEtiquetaNotas()).Returns(new List<EtiquetaNota>());
            
            var controller = new Nota_Controller(repo.Object, null);
            var view = controller.Index() as ViewResult;

            Assert.AreEqual("Index", view.ViewName);
        }

        [Test]
        public void Categoria()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());
            repo.Setup(o => o.GetEtiquetaNotas()).Returns(new List<EtiquetaNota>());
            repo.Setup(o => o.GetEtiquetaNotasUsuario(1, 1)).Returns(new List<EtiquetaNota>());

            var controller = new Nota_Controller(repo.Object, claim.Object);
            var view = controller.Etiqueta(1) as ViewResult;

            Assert.AreEqual("Etiqueta", view.ViewName);
        }


        [Test]
        public void Detalle()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());
            repo.Setup(o => o.GetEtiquetaNotas()).Returns(new List<EtiquetaNota>());
            repo.Setup(o => o.GetNota(1)).Returns(new Nota());

            var controller = new Nota_Controller(repo.Object, claim.Object);
            var view = controller.Detalle(1) as ViewResult;

            Assert.AreEqual("Detalle", view.ViewName);
        }
        [Test]
        public void Create()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());

            var controller = new Nota_Controller(repo.Object, claim.Object);
            var view = controller.Create() as ViewResult;

            Assert.AreEqual("Create", view.ViewName);
        }
        [Test]
        public void CreatePostA()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.GuardarNota(new Nota()));
            repo.Setup(o => o.GuardarEtiqueNota(new List<EtiquetaNota>()));

            var controller = new Nota_Controller(repo.Object, claim.Object);
            var view = controller.Create(new Nota(), new List<int>() { 1 }) as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }
        [Test]
        public void CreatePostB()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());

            var controller = new Nota_Controller(repo.Object, claim.Object);
            var view = controller.Create(new Nota(), new List<int>() { }) as ViewResult;

            Assert.AreEqual("Create", view.ViewName);
        }
        [Test]
        public void Edit()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.GetEtiquetas()).Returns(new List<Etiqueta>());

            var controller = new Nota_Controller(repo.Object, claim.Object);
            var view = controller.Edit(1) as ViewResult;

            Assert.AreEqual("Edit", view.ViewName);
        }
        [Test]
        public void EditPostA()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();
            repo.Setup(o => o.EliminaEtiquetas(1));
            repo.Setup(o => o.ActNota(new Nota()));
            repo.Setup(o => o.GuardarEtiqueNota(new List<EtiquetaNota>()));

            var controller = new Nota_Controller(repo.Object, claim.Object);
            var view = controller.Edit(new Nota()) as RedirectToActionResult;

            Assert.AreEqual("Index", view.ActionName);
        }
        [Test]
        public void Eliminar()
        {
            var claim = new Mock<IClaimService>();
            claim.Setup(o => o.GetLoggedUser()).Returns(new User());
            var repo = new Mock<INotaRepository>();

            var controller = new Nota_Controller(repo.Object, claim.Object);
            controller.Eliminar(1);

            Assert.AreEqual(null, null);
        }

    }
    
}
