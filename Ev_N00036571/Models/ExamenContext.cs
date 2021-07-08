using Ev_N00036571.Models.Map;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_N00036571.Models
{
    public interface IExamenContext
    {
        DbSet<User> Usuarios { get; set; }
        DbSet<Nota> Notas { get; set; }
        int SaveChanges();
    }
    public class ExamenContext :DbContext, IExamenContext
    {
        public DbSet<Nota> Notas { get; set; }
        public DbSet<Etiqueta> Etiquetas { get; set; }
        public DbSet<EtiquetaNota> EtiquetaNota { get; set; }
        public DbSet<User> Usuarios { get; set; }
        public ExamenContext(DbContextOptions<ExamenContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new NotaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaMap());
            modelBuilder.ApplyConfiguration(new EtiquetaNotaMap());


        }

    }
}
