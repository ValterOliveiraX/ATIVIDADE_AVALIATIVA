using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace ATIVIDADE_AVALIATIVA.Controlers
{
    using ATIVIDADE_AVALIATIVA.DAO;
    using ATIVIDADE_AVALIATIVA.Models;
    using MySql.Data.MySqlClient;
    using System;
    using System.Windows.Forms;

    public class PessoaController
    {
        private readonly PessoaDAO pessoaDAO;

        public PessoaController()
        {
            // Instancia o DAO para ser utilizado no controller
            pessoaDAO = new PessoaDAO();
        }


        // Método para inserir Pessoa, Endereço e Contato de uma vez
        public void InserirPessoaCompleta(PessoaModel pessoa, EnderecoModel endereco, ContatoModel contato)
        {
            // Chama o método no DAO que realiza a inserção completa
            try
            {
                pessoaDAO.InserirPessoaCompleta(pessoa, endereco, contato);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex.Message);
            }
        }
        //buscar pessoas

        public List<PessoaModel> BuscarPessoas(string nome, string estadoCivil)
        {
            List<PessoaModel> pessoas = new List<PessoaModel>();
            using (var conexao = new MySqlConnection("server=localhost;uid=root;database=CadastroDePessoas"))
            {
                conexao.Open();

                string query = "SELECT * FROM Pessoa WHERE 1=1";
                if (!string.IsNullOrEmpty(nome))
                {
                    query += " AND nome LIKE @nome";
                }
                if (!string.IsNullOrEmpty(estadoCivil))
                {
                    query += " AND estadoCivil = @estadoCivil";
                }

                using (var cmd = new MySqlCommand(query, conexao))
                {
                    if (!string.IsNullOrEmpty(nome))
                    {
                        cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
                    }
                    if (!string.IsNullOrEmpty(estadoCivil))
                    {
                        cmd.Parameters.AddWithValue("@estadoCivil", estadoCivil);
                    }

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PessoaModel pessoa = new PessoaModel()
                            {
                                IdPessoa = reader.GetInt32("idPessoa"),
                                Nome = reader.GetString("nome"),
                                DataNasc = reader.GetDateTime("dataNasc"),
                                EstadoCivil = reader.GetString("estadoCivil"),
                                Sexo = reader.GetString("sexo")
                            };
                            pessoas.Add(pessoa);
                        }
                    }
                }
            }
            return pessoas;
        }
    }
}


