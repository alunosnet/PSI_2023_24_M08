using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_Compras
{
    public partial class Form1 : Form
    {
        float total = 0;
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Adicionar o produto à lista de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //recolher os dados das textbox
            string produto=tb_produto.Text;
            try
            {
                float quantidade = float.Parse(tb_quantidade.Text);
                float preco=float.Parse(tb_preco.Text);
                //verificar se escreveu o produto
                if (produto.Trim().Length == 0)
                {
                    throw new Exception("Tem de indicar o nome do produto.");
                }
                //adicionar à listbox
                lb_lista_compras.Items
                    .Add(String.Format("{0} - {1:N2} - {2:C}", produto, quantidade, preco));
                //atualizar o total
                total = total + (preco * quantidade);
                lbl_total_pagar.Text=total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro:" + ex.Message);
            }
        }
        /// <summary>
        /// Limpar a lista de compras
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            lb_lista_compras.Items.Clear();
            total = 0;
            lbl_total_pagar.Text=total.ToString("C");

        }
    }
}
