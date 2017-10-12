using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Ex_Prova_Lab2_092017.Models
{
    public class Ingresso
    {
        public int IngressoId { get; set; }
        public TipoIngresso Tipo { get; set; }
        public List<Sessao> Sessoes { get; set; }
        
    }
}