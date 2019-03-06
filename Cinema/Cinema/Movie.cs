using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Movie
    {
        //Atributos da Classe
        public String filme;
        public int sala;
        public String diadasemana;
        public Double preco;
        public Double resultado;


        //Método
        public void CalcularPreco()
        {
            this.preco = 8;
            if (this.diadasemana == "Quarta")
            {
                this.resultado = this.preco - (this.preco * 0.5);
            }
            if(this.diadasemana != "Quarta")
            {
                this.resultado = this.preco;
            }
            
            

            
        }
    }
}
