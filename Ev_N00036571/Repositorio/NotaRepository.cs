using System.Collections.Generic;
using System.Linq;
using Ev_N00036571.Models;
using Microsoft.EntityFrameworkCore;

namespace Ev_N00036571.Repositorio
{
    public interface INotaRepository
    {
        List<Etiqueta> GetEtiquetas();
        Nota GetNota(int id);
        List<EtiquetaNota> GetEtiquetaNotas();
        List<EtiquetaNota> GetEtiquetaNotasUsuario(int IdUsuario, int IdCategoria);
        List<Nota> GetNotas(int idUser);

        void GuardarNota(Nota nota);
        void ActNota(Nota nota);
        void GuardarEtiqueNota(List<EtiquetaNota> et);

        void EliminaNota(int id);
        void EliminaEtiquetas(int id);
    }
    public class NotaRepository : INotaRepository

    {
        private readonly ExamenContext context;

        public NotaRepository(ExamenContext context)
        {
            this.context = context;

        }
        public Nota GetNota(int id)
        {
            return context.Notas.Where(o => o.Id == id).FirstOrDefault();
        }

        public List<EtiquetaNota> GetEtiquetaNotas()
        {
            return context.EtiquetaNota.Include(o => o.Etiqueta).Include(o => o.nota).ToList();
        }

        public List<Etiqueta> GetEtiquetas()
        {
            return context.Etiquetas.ToList();
        }
        public List<Nota> GetNotas(int idUser)
        {
            return context.Notas.Where(o => o.IdUsuario == idUser).ToList();

        }
        public void GuardarNota(Nota nota)
        {
            context.Notas.Add(nota);
            context.SaveChanges();
        }
        public void GuardarEtiqueNota(List<EtiquetaNota> et)
        {
            context.EtiquetaNota.AddRange(et);
            context.SaveChanges();
        }
        public void EliminaNota(int id)
        {
            var nota = context.Notas.Where(o => o.Id == id).FirstOrDefault();
            var etiqueta = context.EtiquetaNota.Where(o => o.IdNota == id).ToList();
            context.Notas.Remove(nota);
            context.EtiquetaNota.RemoveRange(etiqueta);
            context.SaveChanges();

        }
        public void EliminaEtiquetas(int id)
        {
            var etiquetta = context.EtiquetaNota.Where(o => o.Id == id).FirstOrDefault();
            context.EtiquetaNota.RemoveRange(etiquetta);
        }
        public void ActNota(Nota nota)
        {

            context.Notas.Update(nota);
            context.SaveChanges();
        }

        public List<EtiquetaNota> GetEtiquetaNotasUsuario(int IdUsuario, int IdCategoria)
        {
            return context.EtiquetaNota
                .Include(o => o.Etiqueta)
                .Include(o => o.nota)
                .Where(o => o.nota.IdUsuario == IdUsuario && o.Id_etiqueta == IdCategoria)
                .ToList();
        }
    }
}