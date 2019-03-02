using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestauranteEx3
{
    class Lanchonete
    {
        //Atributos da classe
        public String produto;
        public String refri;
        public int QtoProduto;
        public int QtoRefri;
        public Double PrecoRefri;
        public Double PrecoLanche;
        public Double Total;


        //Método
         public void CalularTotaldaConta()
         {
            //Verifica o Valor do lanche
            if(this.produto == "Cachorro Quente R$ 10,00")
            {
                PrecoLanche = 10;
            }
            if (this.produto == "X-Salada R$ 12,00")
            {
                PrecoLanche = 12;
            }
            if (this.produto == "X-Egg  R$15,00")
            {
                PrecoLanche = 15;
            }
            if (this.produto == "X-Tudo R$ 18,00")
            {
                PrecoLanche = 17;
            }
            //Escolhas para o valor do Refrigerante
            switch (refri)
            {
                case "Coca-Cola R$ 5,00":
                    this.PrecoRefri=5;
                    break;
                case "Sprite R$ 4,00":
                    this.PrecoRefri = 4;
                    break;
                case "Fanta R$ 3,00":
                    this.PrecoRefri = 3;
                    break;
                default:
                    this.PrecoRefri = 0;
                    break;
            }
            //verificando se a Quantidade de Refrigerante é maior ou igual a zero
            if(this.QtoRefri >= 0)
            {
                this.PrecoRefri =0;
            }
            //Calculando o Valor total do Lanche e da Compra    
            if (PrecoLanche >=0)
            {
                if(this.PrecoLanche >= 0)
                {
                   this.Total= (this.PrecoLanche * this.QtoProduto) + (this.PrecoRefri * this.QtoRefri);
                }
            }
            
            
         }
    }
}
