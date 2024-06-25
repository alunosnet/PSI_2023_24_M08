using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_numeros
{
    public partial class Form1 : Form
    {
        int soma = 0;
        int contar = 0;
        int maior = 0;
        int menor = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(tb_numero.Text);
                soma += numero;
                contar++;
                float media = (float)soma / contar;
                if (contar==1)
                {
                    maior = menor = numero;
                }
                else
                {
                    if (numero > maior) maior = numero;
                    if (numero < menor) menor = numero;
                }
                lb_resultado.Text ="Média: " + media + "\nMaior: "+maior + "\nMenor: "+menor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorrreu o seguinte erro:" + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Visible = !pictureBox1.Visible;
        }
    }
}
