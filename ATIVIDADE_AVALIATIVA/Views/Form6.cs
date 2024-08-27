using ATIVIDADE_AVALIATIVA.Controlers;
using ATIVIDADE_AVALIATIVA.Models;
using System;
using System.Windows.Forms;

namespace ATIVIDADE_AVALIATIVA
{
    public partial class cadastrar : Form
    {
        public cadastrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Criando instâncias dos modelos com os dados do formulário
            PessoaModel pessoa = new PessoaModel
            {
                Nome = txtNome.Text,
                DataNasc = dtpDataNasc.Value,
                EstadoCivil = cbEstadoCivil.Text,
                Sexo = cbSexo.Text
            };

            EnderecoModel endereco = new EnderecoModel
            {
                NomeDaRua = txtRua.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Numero = Convert.ToInt32(txtNumero.Text),
                Estado = cbEstado.Text,
                Cep = txtCep.Text
            };

            ContatoModel contato = new ContatoModel
            {
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text
            };

            // Criando uma instância do controlador
            PessoaController controller = new PessoaController();

            // Inserindo os dados completos
            controller.InserirPessoaCompleta(pessoa, contato, endereco);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
