using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lb_media.Text = "Clique no botão para calcular a média.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //recolher os valores das tb
            string str_n1 = tb_n1.Text;
            int n1 = int.Parse(str_n1);
            int n2 = int.Parse(tb_n2.Text);
            int n3 = int.Parse(tb_n3.Text);
            //calcular a média
            float media = (n1 + n2 + n3) / 3.0f;
            //informar o utilizador se a média é positiva ou negativa
            if (media >=0)
            {
                MessageBox.Show("Tem a média positiva", "Média");
            }
            else
            {
                MessageBox.Show("A sua média é negativa", "Média");
            }
            //mostrar a média
            lb_media.Text = "Média igual a :" + media.ToString();
        }
    }
}
