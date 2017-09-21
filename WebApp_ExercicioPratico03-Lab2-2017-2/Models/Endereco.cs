using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp_ExercicioPratico03_Lab2_2017_2.Models
{
    public class Endereco
    {
        [ForeignKey("Estudante")]
        public int EnderecoId { get; set; }
        public string Endereco1 { get; set; }
        public string Endereco2 { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public Estudante Estudante { get; set; }

    }
}