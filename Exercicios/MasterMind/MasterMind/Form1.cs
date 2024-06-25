using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterMind
{
    public partial class Form1 : Form
    {
        int[] codigo;
        public Form1()
        {
            InitializeComponent();
            codigo = GerarCodigo();
            lb_sorteio.Text = "****";
        }
        /// <summary>
        /// Opção sair do menu Ficheiro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Opção sobre do Menu Ajuda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir o form sobre
            f_sobre form = new f_sobre();
            //  form.label1.Text = "Mudar o texto";
            form.ShowDialog();
        }
        //Função que devolve um array com o código que o jogador tem de adivinhar
        int[] GerarCodigo()
        {
            Random sortear = new Random();
            int[] codigo = new int[4];
            for (int i = 0; i < codigo.Length; i++)
            {
                codigo[i] = sortear.Next(0, 10);
            }
            return codigo;
        }
        //botão para testar a tentativa do player
        private void button1_Click(object sender, EventArgs e)
        {
            string tentativa = tb_tentativa.Text;

            string feedback = "";

            for (int i = 0;i<4;i++)
            {
                feedback += testar(tentativa, i);
            }
            lb_respostas.Items.Add(tentativa + " - "+feedback);
            //verificar se ganhou e se quer jogar novamente
            if (feedback=="CCCC")
            {
                DialogResult resposta = MessageBox
                    .Show("Parabéns adivinhou o código secreto. Deseja jogar novamente?",
                    "Game Over", MessageBoxButtons.YesNo);
                if (resposta==DialogResult.Yes)
                {
                    lb_respostas.Items.Clear();
                    codigo=GerarCodigo();
                    tb_tentativa.Clear();
                    tb_tentativa.Focus();
                }
            }
        }

        string testar(string tentativa, int posicao)
        {
            //está certo
            if (codigo[posicao].ToString() == tentativa[posicao].ToString())
            {
                return "C";
            }
            for (int i = 0; i < codigo.Length; i++)
            {
                if (codigo[i].ToString() == tentativa[posicao].ToString())
                    return "E"; //existe mas na posição errada
            }
            return "X";
        }
    }
}
