using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pagamento
{
    public partial class Form1 : Form
    {
        //Estanciando Classe funcionario
        funcionario fun = new funcionario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fun.Nome = txtNome.Text;
            fun.Sexo = Convert.ToChar(txtSexo.Text);
            fun.nrodependentes = Convert.ToInt16(txtFilhos.Text);
            fun.salariobase = Convert.ToDouble(txtSalario.Text);

            fun.calcularsalariofamilia();//chamada de método
            //mostrando o resultado numa caixa de diálogo
            MessageBox.Show("Salario Familia: " + fun.salariofamilia);
            //Mostrando o resultado em uma label ou caixa de texto...
            lblSalfamilia.Text = Convert.ToString(fun.salariofamilia);

        }
    }
}
