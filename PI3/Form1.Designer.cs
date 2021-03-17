
namespace PI3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarPartidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarJogadoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarPartidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarEmUmaPartidaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarEmUmaPartidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.versãoDLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(137, 121);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 164);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(137, 143);
            this.textBox1.TabIndex = 2;
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurarToolStripMenuItem,
            this.maximizarToolStripMenuItem,
            this.minimizarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            this.restaurarToolStripMenuItem.Click += new System.EventHandler(this.restaurarToolStripMenuItem_Click);
            // 
            // maximizarToolStripMenuItem
            // 
            this.maximizarToolStripMenuItem.Name = "maximizarToolStripMenuItem";
            this.maximizarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.maximizarToolStripMenuItem.Text = "Maximizar";
            this.maximizarToolStripMenuItem.Click += new System.EventHandler(this.maximizarToolStripMenuItem_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarPartidasToolStripMenuItem,
            this.listarJogadoreToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // listarPartidasToolStripMenuItem
            // 
            this.listarPartidasToolStripMenuItem.Name = "listarPartidasToolStripMenuItem";
            this.listarPartidasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarPartidasToolStripMenuItem.Text = "Listar Partidas";
            this.listarPartidasToolStripMenuItem.Click += new System.EventHandler(this.listarPartidasToolStripMenuItem_Click);
            // 
            // listarJogadoreToolStripMenuItem
            // 
            this.listarJogadoreToolStripMenuItem.Name = "listarJogadoreToolStripMenuItem";
            this.listarJogadoreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarJogadoreToolStripMenuItem.Text = "Listar Jogadores";
            this.listarJogadoreToolStripMenuItem.Click += new System.EventHandler(this.listarJogadoreToolStripMenuItem_Click);
            // 
            // criarPartidaToolStripMenuItem
            // 
            this.criarPartidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarPartidaToolStripMenuItem1,
            this.entrarEmUmaPartidaToolStripMenuItem1});
            this.criarPartidaToolStripMenuItem.Name = "criarPartidaToolStripMenuItem";
            this.criarPartidaToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.criarPartidaToolStripMenuItem.Text = "Partida";
            // 
            // criarPartidaToolStripMenuItem1
            // 
            this.criarPartidaToolStripMenuItem1.Name = "criarPartidaToolStripMenuItem1";
            this.criarPartidaToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.criarPartidaToolStripMenuItem1.Text = "Criar Partida";
            this.criarPartidaToolStripMenuItem1.Click += new System.EventHandler(this.criarPartidaToolStripMenuItem1_Click);
            // 
            // entrarEmUmaPartidaToolStripMenuItem1
            // 
            this.entrarEmUmaPartidaToolStripMenuItem1.Name = "entrarEmUmaPartidaToolStripMenuItem1";
            this.entrarEmUmaPartidaToolStripMenuItem1.Size = new System.Drawing.Size(192, 22);
            this.entrarEmUmaPartidaToolStripMenuItem1.Text = "Entrar em uma Partida";
            this.entrarEmUmaPartidaToolStripMenuItem1.Click += new System.EventHandler(this.entrarEmUmaPartidaToolStripMenuItem1_Click);
            // 
            // entrarEmUmaPartidaToolStripMenuItem
            // 
            this.entrarEmUmaPartidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.versãoDLLToolStripMenuItem});
            this.entrarEmUmaPartidaToolStripMenuItem.Name = "entrarEmUmaPartidaToolStripMenuItem";
            this.entrarEmUmaPartidaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.entrarEmUmaPartidaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sobreToolStripMenuItem.Text = "Sobre...";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.menuToolStripMenuItem,
            this.criarPartidaToolStripMenuItem,
            this.entrarEmUmaPartidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 313);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(37, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Nome: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 339);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(46, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Senha:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(49, 339);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(49, 313);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 7;
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // versãoDLLToolStripMenuItem
            // 
            this.versãoDLLToolStripMenuItem.Name = "versãoDLLToolStripMenuItem";
            this.versãoDLLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.versãoDLLToolStripMenuItem.Text = "Versão DLL...";
            this.versãoDLLToolStripMenuItem.Click += new System.EventHandler(this.versãoDLLToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = ".";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarPartidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarJogadoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarPartidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entrarEmUmaPartidaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem criarPartidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entrarEmUmaPartidaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ToolStripMenuItem versãoDLLToolStripMenuItem;
    }
}

