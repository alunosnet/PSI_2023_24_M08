using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clique no botão para calcular a tabuada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            LimpaListBox();
            //Recolher o valor da textbox tb_numero
            int numero = int.Parse(tb_numero.Text);
            //ciclo para calcular a tabuada
            for (int i = 1; i <= 10; i++) 
            {
                string linha = i + " x " + numero + " = " + numero * i;
                lb_tabuada.Items.Add(linha);
            }
        }
        /// <summary>
        /// Clique no botão para limpar a listbox da tabuada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            LimpaListBox();
        }

        //Função para limpar a listbox
        private void LimpaListBox()
        {
            lb_tabuada.Items.Clear();
        }

        private void tb_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false 
                && char.IsControl(e.KeyChar)==false)
            {
                e.Handled = true;   //cancelar o evento e o digito não é adicionado à tb
            }
        }

        private void lb_tabuada_SelectedIndexChanged(object sender, EventArgs e)
        {
            //qual o elemento selecionado na lb
            int posicao=lb_tabuada.SelectedIndex;
            if (posicao == -1)
            {
                //MessageBox.Show("Tem de selecionar um elemento", "Erro");
                return;
            }
            string texto=lb_tabuada.Items[posicao].ToString();
            DialogResult resposta = MessageBox.Show($"Tem a certeza que pretende remover {texto} ?", 
                "Remover elemento", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                //remover o elemento selecionado
                lb_tabuada.Items.RemoveAt(posicao);
            }
        }
    }
}
