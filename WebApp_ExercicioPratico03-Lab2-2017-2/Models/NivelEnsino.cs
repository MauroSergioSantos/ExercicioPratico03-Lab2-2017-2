using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_ExercicioPratico03_Lab2_2017_2.Models
{
    public class NivelEnsino
    {
        public int NivelEnsinoId { get; set; }
        public string Descricao { get; set; }
        public Estudante Estudante { get; set; }
        public List<Estudante> Estudantes { get; set; }
        public List<Professor> Professores { get; set; }
    }
}