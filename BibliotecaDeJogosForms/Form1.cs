using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeJogosForms.Classes;

namespace BibliotecaDeJogosForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            String titulo = textTitulo.Text;
            String genero = textGenero.Text;
            String ano = textAno.Text;
            String maxJogadores = textJogadores.Text;
            String metaCritic = textMetacritic.Text;

            Jogo jogo = new Jogo(titulo, genero, ano, maxJogadores, metaCritic);
            MessageBox.Show("Jogo adicionado com sucesso!"); 
        }
    }
}
