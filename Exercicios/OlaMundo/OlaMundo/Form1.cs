using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
             * Alterar o texto do label1
             */
            label1.Text = "Olá joaquim!";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nome = tb_nome.Text;
            MessageBox.Show("Olá " + nome);
        }
    }
}
