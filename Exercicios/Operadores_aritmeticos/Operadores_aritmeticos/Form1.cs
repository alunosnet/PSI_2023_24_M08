using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores_aritmeticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            tb_n1.Text = "0";
            tb_n2.Text = "0";
            cb_operadores.SelectedIndex = 0;
            tb_resultado.ReadOnly = true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string op = cb_operadores.Text;
                int n1 = int.Parse(tb_n1.Text);
                int n2 = int.Parse(tb_n2.Text);
                int resultado = 0;
                switch (op)
                {
                    case "+":
                        resultado = n1 + n2;
                        break;
                    case "-":
                        resultado = n1 - n2;
                        break;
                    case "*":
                        resultado = n1 * n2;
                        break;
                    case "/":
                        resultado = n1 / n2;
                        break;
                    default:
                        MessageBox.Show("Tem de escolher um operador");
                        break;
                }
                tb_resultado.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Confirmar que pretende terminar o programa
            DialogResult resposta = MessageBox.Show("Tem a certeza que pretende sair?",
                "Confirmar", MessageBoxButtons.YesNo);
            if (resposta != DialogResult.Yes) 
                e.Cancel = true;
        }
    }
}
