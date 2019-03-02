using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImpressoraEx1
{
    public partial class Form1 : Form
    {
        Pessoa pe = new Pessoa();
        public Form1()
        {
            InitializeComponent();
        }

        private void btoImprimir_Click(object sender, EventArgs e)
        {
            pe.nome = Convert.ToString(txtNome.Text);
            pe.telefone = Convert.ToString(txtTelefone.Text);
            pe.end = Convert.ToString(txtEndereco.Text);

            //Chamando Método
            MessageBox.Show(pe.Imprimir());
        }
    }
}
