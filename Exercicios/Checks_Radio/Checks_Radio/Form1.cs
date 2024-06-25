using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checks_Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Botão para limpar o form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //limpar tb_nome
            tb_nome.Text = "";
            //nb_idade = 18
            nd_idade.Value = 18;
            //radio buttons
            rb_ativo.Checked = true;
            //desativar todas as check box
            ckb_admin.Checked = false;
            ckb_cliente.Checked = false;
            ckb_gestor.Checked = false;
            //lb_mensagem
            lb_mensagem.Text = "";
        }
        /// <summary>
        /// Botão para validar o form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //verificar erros
            if (tb_nome.Text =="")
            {
                lb_mensagem.Text = "Introduza um nome.";
                tb_nome.Focus();
                return;
            }

            //verificar se pelo menos um check box foi selecionada
            if (ckb_admin.Checked == false && ckb_cliente.Checked == false
                && ckb_gestor.Checked == false)
            {
                lb_mensagem.Text = "Selecione pelo menos um perfil de utilizador";
                return;
            }
            string nome=tb_nome.Text;
            string estatuto = nd_idade.Value>66 ? "Reformado" : "Maior de idade";
            /*
            if (nd_idade.Value > 66)
                estatuto = "Reformado";
            else
                estatuto = "Maior de idade";
            */
            string estado = rb_ativo.Checked == true ? "Ativo" : "Bloqueado";
            string perfil = "A tua conta está como ";
            if (ckb_admin.Checked)
                perfil += "Administrador,";
            if (ckb_cliente.Checked)
                perfil += "Cliente,";
            if (ckb_gestor.Checked)
                perfil += "Gestor";
            lb_mensagem.Text = $"Olá {nome}\n És {estatuto}\nA tua conta está {estado}\n{perfil}";
        }
    }
}
