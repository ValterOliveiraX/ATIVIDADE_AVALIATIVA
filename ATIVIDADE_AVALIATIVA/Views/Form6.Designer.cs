namespace ATIVIDADE_AVALIATIVA
{
    partial class cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastrar));
            groupBox1 = new GroupBox();
            cbEstadoCivil = new GroupBox();
            radioButtonSolteiro = new RadioButton();
            radioButtonCasado = new RadioButton();
            cbSexo = new GroupBox();
            radioBtnMasculino = new RadioButton();
            radioBtnFeminino = new RadioButton();
            txtNome = new TextBox();
            label3 = new Label();
            dtpDataNasc = new DateTimePicker();
            label2 = new Label();
            groupBox2 = new GroupBox();
            cbEstado = new ComboBox();
            txtCep = new TextBox();
            txtNumero = new TextBox();
            txtCidade = new TextBox();
            txtBairro = new TextBox();
            txtRua = new TextBox();
            label1 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox3 = new GroupBox();
            txtCelular = new TextBox();
            txtTelefone = new TextBox();
            txtEmail = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnSalvar = new Button();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripLabel1 = new ToolStripLabel();
            groupBox1.SuspendLayout();
            cbEstadoCivil.SuspendLayout();
            cbSexo.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEstadoCivil);
            groupBox1.Controls.Add(cbSexo);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpDataNasc);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 63);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados pessoais";
            // 
            // cbEstadoCivil
            // 
            cbEstadoCivil.Controls.Add(radioButtonSolteiro);
            cbEstadoCivil.Controls.Add(radioButtonCasado);
            cbEstadoCivil.Location = new Point(421, 51);
            cbEstadoCivil.Name = "cbEstadoCivil";
            cbEstadoCivil.Size = new Size(151, 40);
            cbEstadoCivil.TabIndex = 4;
            cbEstadoCivil.TabStop = false;
            cbEstadoCivil.Text = "Estado civil";
            cbEstadoCivil.Enter += cbEstadoCivil_Enter;
            // 
            // radioButtonSolteiro
            // 
            radioButtonSolteiro.AutoSize = true;
            radioButtonSolteiro.Location = new Point(76, 14);
            radioButtonSolteiro.Name = "radioButtonSolteiro";
            radioButtonSolteiro.Size = new Size(65, 19);
            radioButtonSolteiro.TabIndex = 13;
            radioButtonSolteiro.TabStop = true;
            radioButtonSolteiro.Text = "Solteiro";
            radioButtonSolteiro.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasado
            // 
            radioButtonCasado.AutoSize = true;
            radioButtonCasado.Location = new Point(6, 13);
            radioButtonCasado.Name = "radioButtonCasado";
            radioButtonCasado.Size = new Size(64, 19);
            radioButtonCasado.TabIndex = 12;
            radioButtonCasado.TabStop = true;
            radioButtonCasado.Text = "Casado";
            radioButtonCasado.UseVisualStyleBackColor = true;
            radioButtonCasado.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // cbSexo
            // 
            cbSexo.Controls.Add(radioBtnMasculino);
            cbSexo.Controls.Add(radioBtnFeminino);
            cbSexo.Location = new Point(231, 51);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(184, 40);
            cbSexo.TabIndex = 3;
            cbSexo.TabStop = false;
            cbSexo.Text = "sexo";
            // 
            // radioBtnMasculino
            // 
            radioBtnMasculino.AutoSize = true;
            radioBtnMasculino.Location = new Point(6, 15);
            radioBtnMasculino.Name = "radioBtnMasculino";
            radioBtnMasculino.Size = new Size(80, 19);
            radioBtnMasculino.TabIndex = 10;
            radioBtnMasculino.TabStop = true;
            radioBtnMasculino.Text = "Masculino";
            radioBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // radioBtnFeminino
            // 
            radioBtnFeminino.AutoSize = true;
            radioBtnFeminino.Location = new Point(92, 15);
            radioBtnFeminino.Name = "radioBtnFeminino";
            radioBtnFeminino.Size = new Size(75, 19);
            radioBtnFeminino.TabIndex = 11;
            radioBtnFeminino.TabStop = true;
            radioBtnFeminino.Text = "Feminino";
            radioBtnFeminino.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(65, 22);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(687, 23);
            txtNome.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 66);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 1;
            label3.Text = "Data de nascimento";
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Format = DateTimePickerFormat.Short;
            dtpDataNasc.Location = new Point(124, 61);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.Size = new Size(101, 23);
            dtpDataNasc.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 25);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "nome";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbEstado);
            groupBox2.Controls.Add(txtCep);
            groupBox2.Controls.Add(txtNumero);
            groupBox2.Controls.Add(txtCidade);
            groupBox2.Controls.Add(txtBairro);
            groupBox2.Controls.Add(txtRua);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(12, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 90);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Endereço";
            // 
            // cbEstado
            // 
            cbEstado.FormattingEnabled = true;
            cbEstado.Items.AddRange(new object[] { "Acre - AC", "Alagoas - AL", "Amapá - AP", "Amazonas - AM", "Bahia - BA", "Ceará - CE", "Distrito Federal - DF", "Espírito Santo - ES", "Goiás - GO", "Maranhão - MA", "Mato Grosso - MT", "Mato Grosso do Sul - MS", "Minas Gerais - MG", "Pará - PA", "Paraíba - PB", "Paraná - PR", "Pernambuco - PE", "Piauí - PI", "Rio de Janeiro - RJ", "Rio Grande do Norte - RN", "Rio Grande do Sul - RS", "Rondônia - RO", "Roraima - RR", "Santa Catarina - SC", "São Paulo - SP", "Sergipe - SE", "Tocantins - TO" });
            cbEstado.Location = new Point(585, 46);
            cbEstado.Name = "cbEstado";
            cbEstado.Size = new Size(167, 23);
            cbEstado.TabIndex = 12;
            cbEstado.SelectedIndexChanged += cbEstado_SelectedIndexChanged;
            // 
            // txtCep
            // 
            txtCep.Location = new Point(693, 19);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(59, 23);
            txtCep.TabIndex = 11;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(585, 16);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(68, 23);
            txtNumero.TabIndex = 9;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(331, 44);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(173, 23);
            txtCidade.TabIndex = 8;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(55, 46);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(220, 23);
            txtBairro.TabIndex = 7;
            // 
            // txtRua
            // 
            txtRua.Location = new Point(93, 16);
            txtRua.Name = "txtRua";
            txtRua.Size = new Size(411, 23);
            txtRua.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(660, 18);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "CEP";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(530, 49);
            label8.Name = "label8";
            label8.Size = new Size(42, 15);
            label8.TabIndex = 4;
            label8.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 43);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 3;
            label7.Text = "Cidade";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 43);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 2;
            label6.Text = "Bairro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 19);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 1;
            label5.Text = "Número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 19);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 0;
            label4.Text = "Nome da Rua";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtCelular);
            groupBox3.Controls.Add(txtTelefone);
            groupBox3.Controls.Add(txtEmail);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(16, 275);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(257, 119);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Contatos";
            // 
            // txtCelular
            // 
            txtCelular.Location = new Point(57, 79);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(180, 23);
            txtCelular.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(63, 52);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(174, 23);
            txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(53, 26);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 23);
            txtEmail.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(9, 78);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 2;
            label11.Text = "Celular";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(9, 52);
            label10.Name = "label10";
            label10.Size = new Size(51, 15);
            label10.TabIndex = 1;
            label10.Text = "Telefone";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(11, 28);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 0;
            label9.Text = "Email";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
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
            sairToolStripMenuItem.Size = new Size(92, 22);
            sairToolStripMenuItem.Text = "sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.BackColor = Color.Lime;
            btnSalvar.Location = new Point(365, 286);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(335, 96);
            btnSalvar.TabIndex = 8;
            btnSalvar.Text = "SALVAR DADOS";
            btnSalvar.UseVisualStyleBackColor = false;
            btnSalvar.Click += button1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.ButtonHighlight;
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripLabel1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.Stretch = true;
            toolStrip1.TabIndex = 9;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageAlign = ContentAlignment.BottomCenter;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(46, 22);
            toolStripLabel1.Text = "salvar...";
            // 
            // cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 406);
            Controls.Add(toolStrip1);
            Controls.Add(btnSalvar);
            Controls.Add(menuStrip1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "cadastrar";
            Text = "cadastro";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            cbEstadoCivil.ResumeLayout(false);
            cbEstadoCivil.PerformLayout();
            cbSexo.ResumeLayout(false);
            cbSexo.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private CheckedListBox checkedListBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Label label3;
        private DateTimePicker dtpDataNasc;
        private Label label2;
        private Label label1;
        private GroupBox cbSexo;
        private TextBox txtNome;
        private GroupBox cbEstadoCivil;
        private Button btnSalvar;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripLabel toolStripLabel1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label10;
        private Label label9;
        private TextBox txtCep;
        private TextBox txtNumero;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private TextBox txtRua;
        private TextBox txtCelular;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private RadioButton radioButtonSolteiro;
        private RadioButton radioButtonCasado;
        private RadioButton radioBtnMasculino;
        private RadioButton radioBtnFeminino;
        private ComboBox cbEstado;
    }
}