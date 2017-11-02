using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_Ex_Prova_Lab2_092017.Models
{
    public class Localizacao
    {
        public int LocalizacaoId { get; set; }
        public string Descricao { get; set; }
        public string PontoReferencia { get; set; }
        public virtual Sala Sala { get; set; }
    }

}