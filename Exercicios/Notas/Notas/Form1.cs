using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float p1, p2, p3;
            float n1, n2, n3;
            try
            {
                p1 = float.Parse(tb_perc1.Text);
                p2 = float.Parse(tb_perc2.Text);
                p3 = float.Parse(tb_perc3.Text);
                n1 = float.Parse(tb_nota1.Text);
                n2 = float.Parse(tb_nota2.Text);
                n3 = float.Parse(tb_nota3.Text);
                float nota = (p1 * n1) / 100 + (p2 * n2) / 100 + (p3 * n3) / 100;
                lb_nota.Text = "A sua nota final é " + nota;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu o seguinte erro: " + ex.Message);
            }
        }
    }
}
