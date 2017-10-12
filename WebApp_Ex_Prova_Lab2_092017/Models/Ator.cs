using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Ex_Prova_Lab2_092017.Models
{
    public class Ator
    {
        public int AtorId { get; set; }
        public string AtorNome { get; set; }
        public List<Filme> Filmes { get; set; }
        public int FilmeId { get; set; }
    }
}