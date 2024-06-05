using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M08_exercicio_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //adicionar cb_nomes
            string nome=tb_nome.Text;
            if (nome.Trim()=="")
            {
                MessageBox.Show("Tem de inserir um nome");
                tb_nome.Focus();
                return;
            }
            //verificar se o nome já existe
            for(int i=0;i<cb_nomes.Items.Count;i++)
            {
                if (nome == cb_nomes.Items[i].ToString())
                {
                    MessageBox.Show("Nome repetido!");
                    tb_nome.Focus();
                    return;
                }
            }
            cb_nomes.Items.Add(nome);
            //limpar a tb_nome
            tb_nome.Text = "";
            tb_nome.Focus();
        }

        private void cb_nomes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar se selecionou um nome
            if (cb_nomes.SelectedIndex == -1)
            {
                return;
            }
            int posicao = cb_nomes.SelectedIndex;
            DialogResult resposta =
                MessageBox.Show($"Tem a certeza que pretende remover o nome {cb_nomes.Text} ?",
                "Confirmar remover", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
                cb_nomes.Items.RemoveAt(posicao);
        }
    }
}
