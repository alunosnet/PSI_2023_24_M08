using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromo
{
    public partial class f_principal : Form
    {
        public f_principal()
        {
            InitializeComponent();
            //mostrar o splash screen
            f_splash form = new f_splash();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string palavra = textBox1.Text;
            
            //percorrer metade da string
            for(int i=0;i<palavra.Length/2;i++)
            {
                char primeira_letra=palavra[i];
                char segunda_letra = palavra[palavra.Length-1-i];
                if (primeira_letra!=segunda_letra)
                {
                    MessageBox.Show("Não é palindromo");
                    return;
                }
            }
            MessageBox.Show("É um palindromo");
        }
    }
}
