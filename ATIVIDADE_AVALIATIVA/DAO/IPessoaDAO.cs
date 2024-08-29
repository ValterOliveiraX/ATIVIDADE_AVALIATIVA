using ATIVIDADE_AVALIATIVA.DTO;
using ATIVIDADE_AVALIATIVA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Interface DAO para a classe Pessoa
namespace ATIVIDADE_AVALIATIVA.DAO
{
    public interface IPessoaDAO
    {
        void Inserir(PessoaModel pessoa);
        PessoaModel BuscarPorId(int idPessoa);
        List<PessoaModel> BuscarTodos();
        void Atualizar(PessoaModel pessoa);
        void Excluir(int idPessoa);
        void InserirPessoaCompleta(PessoaModel pessoa, EnderecoModel endereco, ContatoModel contato);


    }
}
