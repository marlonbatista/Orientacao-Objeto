using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestauranteEx3
{
    public partial class Form1 : Form
    {   
        //Estanciando Classe
        Lanchonete lan = new Lanchonete();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Repassando Valores aos atributos da Classe Lanchonete
            lan.produto = PrecoLan.Text;
            lan.refri = PrecoRef.Text;
            lan.QtoProduto = Convert.ToInt16(QtoLan.Text);
            lan.QtoRefri = Convert.ToInt32(QtoRef.Text);

            //Chamando Metodo CalularTotaldaConta()
            lan.CalularTotaldaConta();

            MessageBox.Show("\nLanche :" + lan.produto +
                            "\nQuantidade : " + lan.QtoProduto +
                            "\nRefrigerante : " + lan.refri +
                            "\nQuantidade : " + lan.QtoRefri +
                            "\nTotal :R$" + lan.Total+",00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para fechar o Programa
            Close();
        }
    }
}
