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
    public partial class excluir : Form
    {
        public excluir()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvResultados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvResultados.AutoGenerateColumns = false;
            dgvResultados.ColumnCount = 3;

            dgvResultados.Columns[0].Name = "IdPessoa";
            dgvResultados.Columns[0].HeaderText = "ID";
            dgvResultados.Columns[0].DataPropertyName = "IdPessoa";

            dgvResultados.Columns[1].Name = "Nome";
            dgvResultados.Columns[1].HeaderText = "Nome";
            dgvResultados.Columns[1].DataPropertyName = "Nome";

            dgvResultados.Columns[2].Name = "EstadoCivil";
            dgvResultados.Columns[2].HeaderText = "Estado Civil";
            dgvResultados.Columns[2].DataPropertyName = "EstadoCivil";

            // Opcional: Ajustar o tamanho das colunas automaticamente
            dgvResultados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nome = txtNomeBusca.Text;
            string estadoCivil = cbEstadoCivilBusca.SelectedItem?.ToString();

            PessoaController pessoaController = new PessoaController();
            List<PessoaModel> pessoas = pessoaController.BuscarPessoas(nome, estadoCivil);

            dgvResultados.DataSource = pessoas;
        }
    }
}
