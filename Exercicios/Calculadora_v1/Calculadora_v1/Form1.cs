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
        int anterior = 0;           //guardar o resultado ou número anterior
        string operacao = "";       //guarda a operação a realizar
        bool limpar = false;        //guarda se é necessário limpar o tb_numero
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
            if (limpar == true)
                tb_numero.Clear();
            limpar = false;
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
            tb_numero.Text = "0";
            operacao = "";
            anterior = 0;
        }
        /// <summary>
        /// Clique num botão de operação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click(object sender, EventArgs e)
        {
            Button bt_op = (Button)sender;
            limpar = true;
            //verificar se existe uma operação anterior
            if (operacao == "")
            {
                //não existe operação anterior
                anterior = int.Parse(tb_numero.Text);
                operacao = bt_op.Text;
            }
            else
            {
                int atual = int.Parse(tb_numero.Text);
                int resultado = 0;
                switch (operacao)
                {
                    case "+":
                        resultado = anterior + atual;
                        break;
                    case "-":
                        resultado = anterior - atual;
                        break;
                    case "*":
                        resultado = anterior * atual;
                        break;
                    case "/":
                        resultado = anterior / atual;
                        break;
                }
                tb_numero.Text = resultado.ToString();
                if (bt_op.Text == "=")
                {
                    anterior = 0;
                    operacao = "";
                }
                else
                {
                    anterior = resultado;
                    operacao = bt_op.Text;
                }
            }
        }
    }
}
