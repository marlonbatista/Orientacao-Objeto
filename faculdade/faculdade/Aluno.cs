using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faculdade
{
    class Aluno
    {
        //Atributos
        public String nome;
        public Boolean ehbolsista;
        public Double mensalidade;

        //Método

        public void CalcularMensalidade()
        {
            if(this.ehbolsista == true)
            {
                this.mensalidade = 400;
            }
            else
            {
                this.mensalidade = 700;
            }
        }
    }
}
