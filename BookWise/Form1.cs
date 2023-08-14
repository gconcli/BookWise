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

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            string cpf = txtCPF.Text;
            cpf = cpf.Replace(".", "").Replace("-", ""); // Remove a pontuação já existente

            if (cpf.Length > 11)
            {
                cpf = cpf.Substring(0, 11); // Limita até 11 caracteres
            }
            if (cpf.Length >= 3)
            {
                cpf = cpf.Insert(3, ".");
            }
            if (cpf.Length >= 7)
            {
                cpf = cpf.Insert(7, ".");
            }
            if (cpf.Length >= 11)
            {
                cpf = cpf.Insert(11, "-");
            }

            txtCPF.Text = cpf;
            txtCPF.SelectionStart = cpf.Length; // Continua com o cursor até o fim
        }

        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            string cep = txtCEP.Text;
            cep = cep.Replace("-", ""); // Remove o hífem já existente

            if (cep.Length > 8)
            {
                cep = cep.Substring(0, 8); // Limita até 8 caracteres
            }
            else if (cep.Length >= 5)
            {
                cep = cep.Insert(5, "-");
            }

            txtCEP.Text = cep;
            txtCEP.SelectionStart = cep.Length; // Continua com o cursor até o fim
        }


        private void Cadastros_Load(object sender, EventArgs e)
        {
            txtCPF.TextChanged += new System.EventHandler(this.txtCPF_TextChanged);
            txtCEP.TextChanged += new System.EventHandler(this.txtCEP_TextChanged);
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
                MessageBox.Show(nomeUsuario + " seu cadastro foi realizado com sucesso!");
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
