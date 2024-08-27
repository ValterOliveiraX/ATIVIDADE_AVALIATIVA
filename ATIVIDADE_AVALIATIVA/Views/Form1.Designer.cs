
namespace ATIVIDADE_AVALIATIVA
{
    partial class home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            menuStrip1 = new MenuStrip();
            arquivoToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            btnExcluir = new Button();
            btnBuscar = new Button();
            btnCadastrar = new Button();
            label1 = new Label();
            btnSair = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(327, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked_1;
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
            // btnExcluir
            // 
            btnExcluir.Location = new Point(12, 168);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(303, 45);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += button1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 117);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(303, 45);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button2_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 68);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(303, 45);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 7;
            label1.Text = "MENU DE USUÁRIOS";
            // 
            // btnSair
            // 
            btnSair.Location = new Point(12, 219);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(303, 45);
            btnSair.TabIndex = 8;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += button4_Click;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 448);
            Controls.Add(btnSair);
            Controls.Add(label1);
            Controls.Add(btnCadastrar);
            Controls.Add(btnBuscar);
            Controls.Add(btnExcluir);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "home";
            Text = "Início";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button btnExcluir;
        private Button btnBuscar;
        private Button btnCadastrar;
        private Label label1;
        private Button btnSair;
    }
}
