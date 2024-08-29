using ATIVIDADE_AVALIATIVA.DTO;
using ATIVIDADE_AVALIATIVA.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implementação DAO para a classe Pessoa
namespace ATIVIDADE_AVALIATIVA.DAO
{
    public class PessoaDAO : IPessoaDAO
    {

        private string connectionString = "server=localhost;uid=root;database=CadastroDePessoas";

        public void Atualizar(PessoaModel pessoa)
        {
            throw new NotImplementedException();
        }

        public PessoaModel BuscarPorId(int idPessoa)
        {
            throw new NotImplementedException();
        }

        public List<PessoaModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public void Excluir(int idPessoa)
        {
            throw new NotImplementedException();
        }

        public void Inserir(PessoaModel pessoa)
        {
            throw new NotImplementedException();
        }

        public void InserirPessoaCompleta(PessoaModel pessoa, EnderecoModel endereco, ContatoModel contato)
        {
            // String de conexão
            string connectionString = "server=localhost;uid=root;database=CadastroDePessoas";

            using (var conexao = new MySqlConnection(connectionString))
            {
                conexao.Open();

                // Iniciando uma transação
                using (var transaction = conexao.BeginTransaction())
                {
                    try
                    {
                        // Inserindo Pessoa e obtendo o ID gerado
                        string queryPessoa = "INSERT INTO Pessoa (nome, dataNasc, estadoCivil, sexo) VALUES (@Nome, @DataNasc, @EstadoCivil, @Sexo)";
                        using (var cmdPessoa = new MySqlCommand(queryPessoa, conexao, transaction))
                        {
                            cmdPessoa.Parameters.AddWithValue("@Nome", pessoa.Nome);
                            cmdPessoa.Parameters.AddWithValue("@DataNasc", pessoa.DataNasc);
                            cmdPessoa.Parameters.AddWithValue("@EstadoCivil", pessoa.EstadoCivil);
                            cmdPessoa.Parameters.AddWithValue("@Sexo", pessoa.Sexo);
                            cmdPessoa.ExecuteNonQuery();

                            // Recupera o ID gerado
                            pessoa.IdPessoa = (int)cmdPessoa.LastInsertedId;
                        }

                        // Inserindo Endereço relacionado à Pessoa
                        string queryEndereco = "INSERT INTO Endereco (nomeDaRua, bairro, cidade, numero, estado, cep, idPessoa) VALUES (@NomeDaRua, @Bairro, @Cidade, @Numero, @Estado, @Cep, @idPessoa)";
                        using (var cmdEndereco = new MySqlCommand(queryEndereco, conexao, transaction))
                        {
                            cmdEndereco.Parameters.AddWithValue("@NomeDaRua", endereco.NomeDaRua);
                            cmdEndereco.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                            cmdEndereco.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                            cmdEndereco.Parameters.AddWithValue("@Numero", endereco.Numero);
                            cmdEndereco.Parameters.AddWithValue("@Estado", endereco.Estado);
                            cmdEndereco.Parameters.AddWithValue("@Cep", endereco.Cep);
                            cmdEndereco.Parameters.AddWithValue("@idPessoa", pessoa.IdPessoa);
                            cmdEndereco.ExecuteNonQuery();
                        }

                        // Inserindo Contato relacionado à Pessoa
                        string queryContato = "INSERT INTO Contatos (email, telefone, celular, idPessoa) VALUES (@Email, @Telefone, @Celular, @idPessoa)";
                        using (var cmdContato = new MySqlCommand(queryContato, conexao, transaction))
                        {
                            cmdContato.Parameters.AddWithValue("@Email", contato.Email);
                            cmdContato.Parameters.AddWithValue("@Telefone", contato.Telefone);
                            cmdContato.Parameters.AddWithValue("@Celular", contato.Celular);
                            cmdContato.Parameters.AddWithValue("@idPessoa", pessoa.IdPessoa);
                            cmdContato.ExecuteNonQuery();
                        }

                        // Se tudo estiver OK, faz o commit da transação
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        // Se ocorrer algum erro, faz o rollback da transação
                        transaction.Rollback();
                        throw new Exception("Erro ao inserir os dados: " + ex.Message);
                    }
                }
            }
        }
        //buscar pessoa completa


        //--------------fim ----------------------------------------------
    }
}
