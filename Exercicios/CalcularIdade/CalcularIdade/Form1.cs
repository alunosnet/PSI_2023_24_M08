using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularIdade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //limitar o datetimepicker à data atual
            dateTimePicker1.MaxDate = DateTime.Now;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataNascimento = dateTimePicker1.Value;

            TimeSpan tempoVida = dataAtual.Date - dataNascimento.Date; 

            lb_idade.Text= ((int)tempoVida.TotalDays/365).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //verificar se nasceu num ano bissexto
            //para ser bissexto o ano tem de ser divisivel por 4
            int ano = dateTimePicker1.Value.Year;

            if (ano % 4 == 0)
            {
                lb_idade.Text = "Nasceu num ano bissexto";
            }
            else
            {
                lb_idade.Text="Nasceu num ano regular";
            }
        }
    }
}
