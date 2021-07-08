using System;
using System.Collections.Generic;
using System.Linq;
using Ev_N00036571.Models;
using Ev_N00036571.Repositorio;
using Ev_N00036571.Servicios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ev_N00036571.Controllers
{
    [Authorize]
    public class Nota_Controller : Controller
    {
        private readonly INotaRepository context;
        private readonly IClaimService claim;
        public Nota_Controller(INotaRepository context, IClaimService claim)
        {
            this.context = context;
            this.claim = claim;
        }
        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.Etiquetas = context.GetEtiquetas();
            ViewBag.Etiquetitas = context.GetEtiquetaNotas();
            return View("Index");
        }
        [HttpGet]
        public IActionResult _Index(string search)
        {
            claim.SetHttpContext(HttpContext);
            var nota = context.GetNotas(claim.GetLoggedUser().Id);
            ViewBag.Etiquetitas = context.GetEtiquetaNotas();
            ViewBag.Etiquetas = context.GetEtiquetas();
            if (!String.IsNullOrEmpty(search))
            {
                nota = nota.Where(o => o.Titulo.Contains(search) || o.Contenido.Contains(search)).ToList();
                return View(nota);
            }
            
                
                return View("_Index", nota);
              
            
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            return View("Create", new Nota());
        }

        [HttpPost]
        public IActionResult Create(Nota nota, List<int> etiqueta)
        {
            nota.Fecha = DateTime.Now;

            List<EtiquetaNota> etic = new List<EtiquetaNota>();
            if (etiqueta.Count() == 0)
                ModelState.AddModelError("etiqueta", "Seleccione uno");

            claim.SetHttpContext(HttpContext);
            nota.IdUsuario = claim.GetLoggedUser().Id;

            if (ModelState.IsValid)
            {
                context.GuardarNota(nota);
                foreach (var item in etiqueta)
                {
                    var etique = new EtiquetaNota();
                    etique.Id_etiqueta = item;
                    etique.IdNota = nota.Id;
                    etic.Add(etique);
                }
                context.GuardarEtiqueNota(etic);
                
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Etiquetas = context.GetEtiquetas();
                return View("Create", nota);
            }

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Etiquetas = context.GetEtiquetas();
            var nota = context.GetNota(id);
            return View("Edit", nota);
        }

        [HttpPost]
        public IActionResult Edit(Nota nota)
        {
            nota.Fecha = DateTime.Now;
           claim.SetHttpContext(HttpContext);
            nota.IdUsuario = claim.GetLoggedUser().Id;
            if (ModelState.IsValid)
            {
                context.ActNota(nota);
                return RedirectToAction("Index");
            }
            else
            {
                Response.StatusCode = 400;
                ViewBag.Etiquetas = context.GetEtiquetas();
                return View("Edit", nota);
            }
        }
        [HttpGet]
        public IActionResult Detalle(int id)
        {

            var etiqueta = context.GetEtiquetas();
            ViewBag.Etiquetas = context.GetEtiquetaNotas();
            var nota = context.GetNota(id);
            return View("Detalle", nota);
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            context.EliminaNota(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Etiqueta(int id)
        {
            claim.SetHttpContext(HttpContext);
            ViewBag.notas = context.GetEtiquetaNotasUsuario(claim.GetLoggedUser().Id, id);
            return View("Etiqueta");
        }


    }
}