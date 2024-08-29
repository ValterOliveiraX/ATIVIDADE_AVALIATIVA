using ATIVIDADE_AVALIATIVA.Controlers;
using ATIVIDADE_AVALIATIVA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATIVIDADE_AVALIATIVA
{
    public partial class buscar : Form
    {
        public buscar()
        {
            InitializeComponent();
        }

        private void cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeBusca.Text;
            string estadoCivil = cbEstadoCivilBusca.SelectedItem?.ToString();

            PessoaController pessoaController = new PessoaController();
            List<PessoaModel> pessoas = pessoaController.BuscarPessoas(nome, estadoCivil);

            dgvResultados.DataSource = pessoas;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
