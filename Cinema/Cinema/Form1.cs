using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        Movie fil = new Movie();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            fil.preco = 8;
            fil.filme = ComboFilme.Text;
            fil.diadasemana = ComboSemana.Text;
            fil.sala = Convert.ToInt16(comboSala.Text);


            //Chamando Método
            fil.CalcularPreco();

            txtResultado.Text = Convert.ToString(fil.resultado);
            MessageBox.Show("\nFilme :" + fil.filme +
                            "\nDia :" + fil.diadasemana +
                            "\nTotal : R$" + fil.resultado);
        }
    }
}
