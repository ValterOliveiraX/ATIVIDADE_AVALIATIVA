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
            // Captura o estado civil diretamente dos RadioButtons
            string estadoCivil = "";
            
            // Cria instâncias dos modelos com os dados do formulário
            PessoaModel pessoa = new PessoaModel()
            {
                Nome = txtNome.Text,
                DataNasc = dtpDataNasc.Value,
               // EstadoCivil = estadoCivil,
                EstadoCivil = radioButtonSolteiro.Checked ? "solteiro" : (radioButtonCasado.Checked ? "casado" : "Outro"),
                // EstadoCivil = radioButton3_CheckedChanged.Checked.ToString(),
                Sexo = radioBtnMasculino.Checked ? "M" : (radioBtnFeminino.Checked ? "F" : "Outro")
            };

            EnderecoModel endereco = new EnderecoModel()
            {
                NomeDaRua = txtRua.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Numero = int.Parse(txtNumero.Text),
                Estado = cbEstado.SelectedItem.ToString(),
                Cep = txtCep.Text
            };

            ContatoModel contato = new ContatoModel()
            {
                Email = txtEmail.Text,
                Telefone = txtTelefone.Text,
                Celular = txtCelular.Text
            };

            // Cria uma instância do controller
            PessoaController pessoaController = new PessoaController();

            // Chama o método para inserir os dados
            pessoaController.InserirPessoaCompleta(pessoa, endereco, contato);
            // Limpa o formulário após a inserção dos dados
            LimparFormulario();
        }

        private void LimparFormulario()
        {
            // Limpa todos os TextBox
            txtNome.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();

            // Reseta a seleção dos ComboBox
            cbEstado.SelectedIndex = -1;

            // Reseta a seleção dos RadioButtons
            radioButtonSolteiro.Checked = false;
            radioButtonCasado.Checked = false;
            radioBtnMasculino.Checked = false;
            radioBtnFeminino.Checked = false;

            // Reseta o DateTimePicker
            dtpDataNasc.Value = DateTime.Now;
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

        private void radioButtonSolteiro_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }


}
