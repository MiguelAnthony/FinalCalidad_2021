using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ev_N00036571.Models.Map
{
    public class EtiquetaNotaMap : IEntityTypeConfiguration<EtiquetaNota>
    {
        public void Configure(EntityTypeBuilder<EtiquetaNota> builder)
        {
            builder.ToTable("EtiquetaNota");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.Etiqueta).
                WithMany().
                HasForeignKey(o => o.Id_etiqueta);
            builder.HasOne(o => o.nota).
                WithMany().
                HasForeignKey(o => o.IdNota);

        }
    }
}
