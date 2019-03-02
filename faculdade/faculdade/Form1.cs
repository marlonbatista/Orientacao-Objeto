using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace faculdade
{
    public partial class Form1 : Form
    {
        //Estanciando Classe
        Aluno alu = new Aluno();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //entrada de dados para os atributos
            alu.nome = txtNome.Text;

            if(checkbolsista.Checked == true)//É bolsista ou seja o checkbox está marcado
            {
                alu.ehbolsista = true; //manda o "true" para o atributo ehbolsista
                alu.CalcularMensalidade();//chama o  método da classe

                //MostraAluno ou seja mostra todos os dados da classe
                MessageBox.Show("\nNome do aluno :" + alu.nome + "Mensalidade :" + alu.mensalidade);
                //Informa o valor da Mensalidade na caixa de texto
                txtResultado.Text = Convert.ToString(alu.mensalidade);
            }
            else
            {
                alu.ehbolsista = false; //Manda o "false" para o atributo ehbolsista

                alu.CalcularMensalidade();//chama o método da classe

                //Mostraaluno ou seja mostra todos os dados da classe
                MessageBox.Show("\nNome do aluno :" + alu.nome + "Mensalidade :" + alu.mensalidade);
                //Informa o vlor da Mensalidade na caixa de texto
                txtResultado.Text = Convert.ToString(alu.mensalidade);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
