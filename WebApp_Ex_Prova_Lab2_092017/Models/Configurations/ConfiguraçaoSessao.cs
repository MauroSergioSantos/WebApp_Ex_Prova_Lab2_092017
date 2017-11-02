using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace WebApp_Ex_Prova_Lab2_092017.Models.Configurations
{
    public class ConfiguraçaoSessao : EntityTypeConfiguration<Sessao>
    {
        public ConfiguraçaoSessao()
        {
            //Configura propriedade para o tipo datetime2
            Property(s => s.DataHoraInicio)
                .HasColumnType("datetime2");

            //Configura propriedade para o tipo datetime2
            Property(s => s.DataHoraFim)
                .HasColumnType("datetime2");
        }
    }
}