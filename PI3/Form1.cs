using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CantStopServer;

namespace PI3
{

    public partial class Form1 : Form
    {

        public int idPartida { get; set; }
        public Form1()
        {

            InitializeComponent();
        }


        private void listarPartidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");

            string[] linha = retorno.Split('\n');

            for (int i = 0; i < linha.Length; i++)
            {
                listBox1.Items.Add(linha[i]);
            }
        }

        private void listarJogadoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string linha = listBox1.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            int id = Convert.ToInt32(itens[0]);

            textBox1.Text = Jogo.ListarJogadores(id);

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(808, 481);
        }

        private void maximizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximumSize = this.Size;
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.MinimumSize = this.Size;
        }

        private void criarPartidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            string nome = textBox5.Text;
            string senha = textBox4.Text;

            string criar = Jogo.CriarPartida(nome,senha);
            
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();

        }

        private void entrarEmUmaPartidaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(textBox4.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(textBox5.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            string nome = textBox5.Text;
            string senha = textBox4.Text;

            string linha = listBox1.SelectedItem.ToString();
            string[] itens = linha.Split(',');
            int id = Convert.ToInt32(itens[0]);

            string entrar = Jogo.EntrarPartida(id,nome, senha);
        }


        private void textBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider.SetError(textBox5, "Por favor insira um nome! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox5, null);
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                e.Cancel = true;
                textBox5.Focus();
                errorProvider.SetError(textBox4, "Por favor insira sua senha! ");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBox4, null);
            }
        }

        private void versãoDLLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão Atual: " + Jogo.Versao);
        }
    }
    }
