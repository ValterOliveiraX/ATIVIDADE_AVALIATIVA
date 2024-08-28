namespace ATIVIDADE_AVALIATIVA
{
    partial class excluir
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            cbEstadoCivilBusca = new ComboBox();
            txtNomeBusca = new TextBox();
            btnExcluir = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            BtnConfirmar = new Button();
            dgvResultados = new DataGridView();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(793, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            arquivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            arquivoToolStripMenuItem.Size = new Size(59, 20);
            arquivoToolStripMenuItem.Text = "arquivo";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(180, 22);
            sairToolStripMenuItem.Text = "sair";
            // 
            // cbEstadoCivilBusca
            // 
            cbEstadoCivilBusca.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEstadoCivilBusca.FormattingEnabled = true;
            cbEstadoCivilBusca.Items.AddRange(new object[] { "Casado", "Solteiro" });
            cbEstadoCivilBusca.Location = new Point(38, 51);
            cbEstadoCivilBusca.Name = "cbEstadoCivilBusca";
            cbEstadoCivilBusca.Size = new Size(121, 23);
            cbEstadoCivilBusca.TabIndex = 7;
            // 
            // txtNomeBusca
            // 
            txtNomeBusca.Location = new Point(66, 22);
            txtNomeBusca.Name = "txtNomeBusca";
            txtNomeBusca.Size = new Size(539, 23);
            txtNomeBusca.TabIndex = 2;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(611, 22);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(145, 55);
            btnExcluir.TabIndex = 6;
            btnExcluir.Text = "BUSCA P/ EXCLUSAO";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEstadoCivilBusca);
            groupBox1.Controls.Add(txtNomeBusca);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 85);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados pessoais";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 25);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "nome";
            // 
            // BtnConfirmar
            // 
            BtnConfirmar.Location = new Point(313, 381);
            BtnConfirmar.Name = "BtnConfirmar";
            BtnConfirmar.Size = new Size(145, 55);
            BtnConfirmar.TabIndex = 7;
            BtnConfirmar.Text = "BUSCA P/ EXCLUSAO";
            BtnConfirmar.UseVisualStyleBackColor = true;
            // 
            // dgvResultados
            // 
            dgvResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResultados.Location = new Point(6, 118);
            dgvResultados.Name = "dgvResultados";
            dgvResultados.Size = new Size(778, 244);
            dgvResultados.TabIndex = 8;
            // 
            // excluir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(793, 448);
            Controls.Add(dgvResultados);
            Controls.Add(BtnConfirmar);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            Name = "excluir";
            Text = "exclusão";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ComboBox cbEstadoCivilBusca;
        private TextBox txtNomeBusca;
        private Button btnExcluir;
        private GroupBox groupBox1;
        private Label label2;
        private Button BtnConfirmar;
        private DataGridView dgvResultados;
    }
}