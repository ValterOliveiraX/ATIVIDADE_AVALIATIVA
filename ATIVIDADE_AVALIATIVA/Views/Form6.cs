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

        private void cbEstadoCivil_Enter(object sender, EventArgs e)
        {
            // Limpa o texto da ComboBox ao entrar
            cbEstadoCivil.Text = "";

            // Verifica qual RadioButton está marcado
            if (radioButtonSolteiro.Checked)
            {
                cbEstadoCivil.Text = "Solteiro";
            }
            else if (radioButtonCasado.Checked)
            {
                cbEstadoCivil.Text = "Casado";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void radioButtonSolteiro_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
