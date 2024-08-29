using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE_AVALIATIVA.DTO
{
    internal class PessoaCompletaDTO
    {
        public int IdPessoa { get; set; }
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string EstadoCivil { get; set; }
        public string Sexo { get; set; }
        public string NomeDaRua { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public int Numero { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
    }
}
