using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro
{
    class Pessoa
    {
        
        //Atributos da Classe
        public String nome;
        public String email;
        public int idade;
       


        public void Cadastrar()
        {
          

        }

        public String Verificar()
        {
            if (this.idade < 18)
            {
                
                return "(MENOR DE IDADE)";

            }
            else
            {
                 
                return "(MAIOR DE IDADE)";
                
            }
           
        }
        
        


    }
}
