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


    }
}


