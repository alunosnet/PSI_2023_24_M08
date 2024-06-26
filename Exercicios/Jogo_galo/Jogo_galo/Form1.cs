using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_galo
{

   
    public partial class Form1 : Form
    {
        bool PlayerAtual = true;
        int[,] board = new int[3, 3];
        int contaroscliquessemcontaroscliquesfora = 0;

        public Form1()
        {
            InitializeComponent();
            LimparBoard();
        }

        private void LimparBoard()
        {
            //limpar o board
            for (int linha = 0; linha < 3; linha++)
                for (int coluna = 0; coluna < 3; coluna++)
                    board[linha, coluna] = 0;
        }

        //Clique nas pictureboxes todas
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            //evitar clicar numa picturebox que já está preenchida
            if (pictureBox.Image != null) return;
            //colocar a imagem correspondente ao jogador
            if (PlayerAtual)
                pictureBox.Image = pb_player1.Image;
            else
                pictureBox.Image = pb_player2.Image;
            //atualizar o board
            string[] posicao=pictureBox.Tag.ToString().Split(';');
            int linha=int.Parse(posicao[0]);
            int coluna=int.Parse(posicao[1]);
            
            board[linha, coluna] = PlayerAtual ? 1 : 2;
            contaroscliquessemcontaroscliquesfora++;

            int jogador = verificarVitoria();
            if (jogador != 0 || contaroscliquessemcontaroscliquesfora==9)
            {
                if (jogador != 0)
                    MessageBox.Show($"Ganhou o jogador {jogador}");
                else
                    MessageBox.Show("Jogo terminou com empate");
                ReporJogo();
            }
            //mudar de jogador
            PlayerAtual = !PlayerAtual;
        }

        private void ReporJogo()
        {
            //limpar as picturebox
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            //limpar o board
            LimparBoard();
            contaroscliquessemcontaroscliquesfora = 0;
            PlayerAtual = true;
        }

        private int verificarVitoria()
        {
            //linhas
            for(int linha = 0;linha < 3; linha++)
            {
                if (board[linha,0]!=0 && board[linha,0]==board[linha,1]
                    && board[linha, 1] == board[linha,2])
                {
                    //vitoria
                    return board[linha,0];
                }
            }
            //colunas
            for(int coluna=0;coluna < 3; coluna++)
            {
                if (board[0,coluna]!=0 && board[0, coluna] == board[1,coluna]
                    && board[1,coluna]==board[2,coluna])
                {
                    return board[0,coluna];
                }
            }
            //diagonais
            if (board[0,0]!=0 && board[0, 0] == board[1,1] && board[1, 1] == board[2,2])
                return board[0,0];
            if (board[0,2]!=0 && board[0, 2] == board[1,1] && board[1, 1] == board[2,0])
                return board[0,2];
            return 0;
        }
    }
}
