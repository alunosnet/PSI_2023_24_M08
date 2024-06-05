using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_v1
{
    public partial class Form1 : Form
    {
        int anterior = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Função para o clique nos botões dos números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender; 
            tb_numero.Text += botao.Text;
        }
        /// <summary>
        /// Botão para limpar a tb_numero (C)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click(object sender, EventArgs e)
        {
            tb_numero.Clear();
        }

    }
}
