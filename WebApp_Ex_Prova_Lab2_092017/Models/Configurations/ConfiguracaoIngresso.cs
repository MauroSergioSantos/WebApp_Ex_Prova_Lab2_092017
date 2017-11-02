using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApp_Ex_Prova_Lab2_092017.Models.Configurations
{
    public class ConfiguracaoIngresso:EntityTypeConfiguration<Ingresso>
    {
        public ConfiguracaoIngresso()
        {
            //Configura associação one-to-many(um-para-muitos)
            HasMany(se => se.Sessoes)
                .WithOptional(i => i.Ingresso)//Associação Opcional(fraca)
                .HasForeignKey(i => i.IngressoId)
                .WillCascadeOnDelete(false);
        }
    }
}