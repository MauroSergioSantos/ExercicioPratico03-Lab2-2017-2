using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp_ExercicioPratico03_Lab2_2017_2.Models
{
    public class Estudante
    {
        public int EstudanteId { get; set; }
        public int EstudanteNome { get; set; }
        public DateTime Datanascimento { get; set; }
        public string Foto { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public int NivelEnsinoId { get; set; }
        public Endereco Endereco { get; set; }
        public List<Curso> Cursos { get; set; }

    }
}