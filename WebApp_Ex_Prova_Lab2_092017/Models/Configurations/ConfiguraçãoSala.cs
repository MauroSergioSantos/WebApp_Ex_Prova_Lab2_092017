using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApp_Ex_Prova_Lab2_092017.Models.Configurations
{
    public class ConfiguracaoSala : EntityTypeConfiguration<Sala>
    {
        public ConfiguracaoSala()
        {
            ToTable("TbSala");
            Property(s => s.Descricao)
           .IsRequired()
           .HasMaxLength(500);

            HasOptional(l => l.Localizacao)
           .WithRequired(s => s.Sala)
           .WillCascadeOnDelete(true);

            HasMany(se => se.Sessoes)
           .WithRequired(s => s.Sala)
           .HasForeignKey(s => s.SalaId)
           .WillCascadeOnDelete(false);

        }
    }
}