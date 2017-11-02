using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Ex_Prova_Lab2_092017.Models
{
    public class Sessao
    {
        public int SessaoId { get; set; }
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public decimal ValorInteira { get; set; }
        public decimal ValorMeia { get; set; }
        public Boolean Encerrada { get; set; }      
        public int SalaId { get; set; }
        public Sala Sala { get; set; }
        public int? IngressoId { get; set; }
        public Ingresso Ingresso { get; set; }
        public int FilmeId { get; set; }
        public Filme Filme { get; set; }



    }
}