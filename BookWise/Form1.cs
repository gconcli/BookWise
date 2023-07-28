using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWise
{
    public partial class Cadastros : Form
    {
        string nomeUsuario;
        public Cadastros()
        {
            InitializeComponent();
        }

        private void iblNome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            nomeUsuario = txtNome.Text;
            if (checkBAceitar.Checked == true)
            {
                MessageBox.Show("Olá " + nomeUsuario + " seu cadastro foi realizado com sucesso!");
            }

            else
            {
                MessageBox.Show("Você precisa aceitar os termos de uso para se cadastrar!");
            }
        }

        private void cbTermos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
