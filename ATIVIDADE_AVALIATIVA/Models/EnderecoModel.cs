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
      public string  nomeDaRua { get; set; }
      public string bairro { get; set; }
      public string cidade { get; set; }
      public int numero { get; set; }
      public string estado { get; set; }
      public string cep { get; set; }
      public int idPessoa { get; set; }   
    }
}
