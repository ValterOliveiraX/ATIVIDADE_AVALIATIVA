using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ATIVIDADE_AVALIATIVA.Controlers
{
    using ATIVIDADE_AVALIATIVA.Models;
    using MySql.Data.MySqlClient;
    using System;
    using System.Windows.Forms;

    public class PessoaController
    {
        private string connectionString = "server=localhost;uid=root;database=CadastroDePessoas";

        public void InserirPessoaCompleta(PessoaModel pessoa, ContatoModel contato, EnderecoModel endereco)
        {
            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Iniciando a transação
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        // Inserindo Pessoa
                        var pessoaQuery = "INSERT INTO Pessoa (nome, dataNasc, estadoCivil, sexo) VALUES (@Nome, @DataNasc, @EstadoCivil, @Sexo); SELECT LAST_INSERT_ID();";
                        MySqlCommand pessoaCommand = new MySqlCommand(pessoaQuery, connection, transaction);
                        pessoaCommand.Parameters.AddWithValue("@Nome", pessoa.Nome);
                        pessoaCommand.Parameters.AddWithValue("@DataNasc", pessoa.DataNasc);
                        pessoaCommand.Parameters.AddWithValue("@EstadoCivil", pessoa.EstadoCivil);
                        pessoaCommand.Parameters.AddWithValue("@Sexo", pessoa.Sexo);

                        // Recuperando o ID gerado para Pessoa
                        int pessoaId = Convert.ToInt32(pessoaCommand.ExecuteScalar());

                        // Inserindo Endereço
                        var enderecoQuery = "INSERT INTO Endereco (nomeDaRua, bairro, cidade, numero, estado, cep, idPessoa) VALUES (@NomeDaRua, @Bairro, @Cidade, @Numero, @Estado, @Cep, @IdPessoa)";
                        MySqlCommand enderecoCommand = new MySqlCommand(enderecoQuery, connection, transaction);
                        enderecoCommand.Parameters.AddWithValue("@NomeDaRua", endereco.NomeDaRua); 
                        enderecoCommand.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                        enderecoCommand.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                        enderecoCommand.Parameters.AddWithValue("@Numero", endereco.Numero);
                        enderecoCommand.Parameters.AddWithValue("@Estado", endereco.Estado);
                        enderecoCommand.Parameters.AddWithValue("@Cep", endereco.Cep);
                        enderecoCommand.Parameters.AddWithValue("@IdPessoa", pessoaId);
                        enderecoCommand.ExecuteNonQuery();

                        // Inserindo Contato
                        var contatoQuery = "INSERT INTO Contatos (email, telefone, celular, idPessoa) VALUES (@Email, @Telefone, @Celular, @IdPessoa)";
                        MySqlCommand contatoCommand = new MySqlCommand(contatoQuery, connection, transaction);
                        contatoCommand.Parameters.AddWithValue("@Email", contato.Email);
                        contatoCommand.Parameters.AddWithValue("@Telefone", contato.Telefone);
                        contatoCommand.Parameters.AddWithValue("@Celular", contato.Celular);
                        contatoCommand.Parameters.AddWithValue("@IdPessoa", pessoaId);
                        contatoCommand.ExecuteNonQuery();

                        // Commit da transação
                        transaction.Commit();

                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        // Rollback da transação em caso de erro
                        transaction.Rollback();
                        MessageBox.Show("Erro ao inserir os dados: " + ex.Message);
                    }
                }
            }
        }
    }

}


