using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_AVALIATIVA.Models
{
    public class PessoaModel
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
    }
}
