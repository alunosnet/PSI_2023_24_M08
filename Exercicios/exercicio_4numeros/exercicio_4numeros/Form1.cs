using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_4numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //recolher do form e converter para inteiro
                int n1 = int.Parse(textBox1.Text);
                int n2 = int.Parse(textBox2.Text);
                int n3 = int.Parse(textBox3.Text);
                int n4 = int.Parse(textBox4.Text);
                //média
                float media = (n1 + n2 + n3 + n4) / 4.0f;
                lb_resultado.Text = "Média : " + media;
                //maior
                int maior = n1;
                if (n2 > maior) maior = n2;
                if (n3 > maior) maior = n3;
                if (n4 > maior) maior = n4;
                lb_resultado.Text += "\nMaior: " + maior;
                //menor
                int menor = n1;
                if (n2 < menor) menor = n2;
                if (n3 < menor) menor = n3;
                if (n4 < menor) menor = n4;
                lb_resultado.Text += "\nMenor: " + menor;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Os dados não são válidos.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime agora= DateTime.Now;
            lb_timer.Text = agora.ToString("HH:mm:ss");
        }
    }
}
