using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa();
            p1.nome = text1.Text;
            p1.email = text2.Text;
            p1.idade = Convert.ToInt16(text3.Text);
            MessageBox.Show("Cadastro Realizado com SUCESSO!" + "\nNome :" + p1.nome 
                + "\nE-mail: " + p1.email + "\nIdade :" + p1.idade+" " + p1.Verificar());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            text1.Clear();
            text2.Clear();
            text3.Clear();
            MessageBox.Show("Tudo Limpo!");
        }
    }
}
