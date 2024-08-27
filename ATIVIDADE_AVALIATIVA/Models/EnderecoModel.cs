using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATIVIDADE_AVALIATIVA.Models
{
    public class EnderecoModel
    {
      public int idEndereco  { get; set; }
      public string  NomeDaRua { get; set; }
      public string Bairro { get; set; }
      public string Cidade { get; set; }
      public int Numero { get; set; }
      public string Estado { get; set; }
      public string Cep { get; set; }
      public int IdPessoa { get; set; }   
    }
}
