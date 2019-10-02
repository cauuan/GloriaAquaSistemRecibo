namespace SistemaAquaRecibo
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnPesquisa = new System.Windows.Forms.Panel();
            this.txtPesPrincipal = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalidadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.responsávelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caixasAnterioresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Selecionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Mat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAluno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Responsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnMostraAluno = new System.Windows.Forms.Panel();
            this.pnLogo.SuspendLayout();
            this.pnPesquisa.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnLogo.Controls.Add(this.pnPesquisa);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLogo.ForeColor = System.Drawing.Color.SkyBlue;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(973, 85);
            this.pnLogo.TabIndex = 0;
            // 
            // pnPesquisa
            // 
            this.pnPesquisa.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnPesquisa.Controls.Add(this.txtPesPrincipal);
            this.pnPesquisa.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnPesquisa.ForeColor = System.Drawing.Color.SteelBlue;
            this.pnPesquisa.Location = new System.Drawing.Point(339, 0);
            this.pnPesquisa.Name = "pnPesquisa";
            this.pnPesquisa.Size = new System.Drawing.Size(634, 85);
            this.pnPesquisa.TabIndex = 0;
            // 
            // txtPesPrincipal
            // 
            this.txtPesPrincipal.Location = new System.Drawing.Point(347, 32);
            this.txtPesPrincipal.Name = "txtPesPrincipal";
            this.txtPesPrincipal.Size = new System.Drawing.Size(270, 22);
            this.txtPesPrincipal.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 455);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(973, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(380, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(593, 100);
            this.panel7.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.menuStrip1);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 85);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(125, 370);
            this.pnMenu.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.pagamentosToolStripMenuItem,
            this.caixaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(150, 370);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.modalidadeToolStripMenuItem,
            this.responsávelToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.AlunoToolStripMenuItem_Click);
            // 
            // modalidadeToolStripMenuItem
            // 
            this.modalidadeToolStripMenuItem.Name = "modalidadeToolStripMenuItem";
            this.modalidadeToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.modalidadeToolStripMenuItem.Text = "Modalidade";
            this.modalidadeToolStripMenuItem.Click += new System.EventHandler(this.ModalidadeToolStripMenuItem_Click);
            // 
            // responsávelToolStripMenuItem
            // 
            this.responsávelToolStripMenuItem.Name = "responsávelToolStripMenuItem";
            this.responsávelToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.responsávelToolStripMenuItem.Text = "Responsável";
            this.responsávelToolStripMenuItem.Click += new System.EventHandler(this.ResponsávelToolStripMenuItem_Click);
            // 
            // pagamentosToolStripMenuItem
            // 
            this.pagamentosToolStripMenuItem.Name = "pagamentosToolStripMenuItem";
            this.pagamentosToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.pagamentosToolStripMenuItem.Text = "Pagamentos";
            // 
            // caixaToolStripMenuItem
            // 
            this.caixaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.caixasAnterioresToolStripMenuItem});
            this.caixaToolStripMenuItem.Name = "caixaToolStripMenuItem";
            this.caixaToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.caixaToolStripMenuItem.Text = "Caixa";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // caixasAnterioresToolStripMenuItem
            // 
            this.caixasAnterioresToolStripMenuItem.Name = "caixasAnterioresToolStripMenuItem";
            this.caixasAnterioresToolStripMenuItem.Size = new System.Drawing.Size(205, 26);
            this.caixasAnterioresToolStripMenuItem.Text = "Caixas Anteriores";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(125, 85);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(848, 370);
            this.panel4.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selecionar,
            this.Mat,
            this.nomeAluno,
            this.Responsavel,
            this.dtNascimento,
            this.Fone});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(848, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "";
            this.Selecionar.MinimumWidth = 6;
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 50;
            // 
            // Mat
            // 
            this.Mat.HeaderText = "Mat";
            this.Mat.MinimumWidth = 6;
            this.Mat.Name = "Mat";
            this.Mat.Width = 50;
            // 
            // nomeAluno
            // 
            this.nomeAluno.HeaderText = "Aluno";
            this.nomeAluno.MinimumWidth = 6;
            this.nomeAluno.Name = "nomeAluno";
            this.nomeAluno.Width = 200;
            // 
            // Responsavel
            // 
            this.Responsavel.HeaderText = "Responsável";
            this.Responsavel.MinimumWidth = 6;
            this.Responsavel.Name = "Responsavel";
            this.Responsavel.Width = 120;
            // 
            // dtNascimento
            // 
            this.dtNascimento.HeaderText = "Nascimento";
            this.dtNascimento.MinimumWidth = 6;
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Width = 120;
            // 
            // Fone
            // 
            this.Fone.HeaderText = "Fone";
            this.Fone.MinimumWidth = 6;
            this.Fone.Name = "Fone";
            this.Fone.Width = 120;
            // 
            // pnMostraAluno
            // 
            this.pnMostraAluno.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pnMostraAluno.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMostraAluno.Location = new System.Drawing.Point(686, 85);
            this.pnMostraAluno.Name = "pnMostraAluno";
            this.pnMostraAluno.Size = new System.Drawing.Size(287, 370);
            this.pnMostraAluno.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 555);
            this.Controls.Add(this.pnMostraAluno);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnLogo);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aqua Recibo";
            this.pnLogo.ResumeLayout(false);
            this.pnPesquisa.ResumeLayout(false);
            this.pnPesquisa.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnPesquisa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnMostraAluno;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalidadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem responsávelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caixasAnterioresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagamentosToolStripMenuItem;
        private System.Windows.Forms.TextBox txtPesPrincipal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Selecionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mat;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAluno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Responsavel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fone;
    }
}

